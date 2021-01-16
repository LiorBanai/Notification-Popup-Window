using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using NotificationWindow.DataTypes;
using Timer = System.Windows.Forms.Timer;

namespace NotificationWindow
{
    /// <summary>
    /// Non-visual component to show a notification window in the right lower
    /// corner of the screen.
    /// </summary>
    [ToolboxBitmap(typeof(PopupNotifier), "Icon.ico")]
    [DefaultEvent("Click")]
    public class PopupNotifier : Component
    {
        internal static List<(int index, int topPosition, PopupNotifier PopupNotifier)> positions = new List<(int index, int topPosition, PopupNotifier PopupNotifier)>();
        private int currentIndex;
        #region Windows API
        private const int SW_SHOWNOACTIVATE = 4;
        private const int HWND_TOPMOST = -1;
        private const uint SWP_NOACTIVATE = 0x0010;

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(
         int hWnd,             // Window handle
         int hWndInsertAfter,  // Placement-order handle
         int X,                // Horizontal position
         int Y,                // Vertical position
         int cx,               // Width
         int cy,               // Height
         uint uFlags);         // Window positioning flags

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static void ShowInactiveTopmost(Form frm)
        {
            ShowWindow(frm.Handle, SW_SHOWNOACTIVATE);
            SetWindowPos(frm.Handle.ToInt32(), HWND_TOPMOST,
            frm.Left, frm.Top, frm.Width, frm.Height,
            SWP_NOACTIVATE);
        }
        #endregion

        /// <summary>
        /// Event that is raised when the text in the notification window is clicked.
        /// </summary>
        public event EventHandler Click;

        /// <summary>
        /// Event that is raised when the notification window is manually closed.
        /// </summary>
        public event EventHandler Close;

        /// <summary>
        /// Event that is raised when the notification Appears.
        /// </summary>
        public event EventHandler Appear;

        /// <summary>
        /// Event that is raised when the notification Dissapers 
        /// </summary>
        public event EventHandler Disappear;

        private bool disposed = false;
        private PopupNotifierForm frmPopup;
        private Timer tmrAnimation;
        private Timer tmrWait;

        private bool isAppearing = true;
        private bool markedForDisposed = false;
        private bool mouseIsOn = false;
        private int maxPosition;
        private double maxOpacity;
        public int posStart;
        private int posStop;
        private double opacityStart;
        private double opacityStop;
        private int realAnimationDuration;
        private Stopwatch sw;

        #region Properties

        [Category("Header"), DefaultValue(typeof(Color), "ControlDark")]
        [Description("Color of the window header.")]
        public Color HeaderColor { get; set; }

        [Category("Appearance"), DefaultValue(typeof(Color), "Control")]
        [Description("Color of the window background.")]
        public Color BodyColor { get; set; }

        [Category("Title"), DefaultValue(typeof(Color), "Gray")]
        [Description("Color of the title text.")]
        public Color TitleColor { get; set; }

        [Category("Content"), DefaultValue(typeof(Color), "ControlText")]
        [Description("Color of the content text.")]
        public Color ContentColor { get; set; }

        [Category("Appearance"), DefaultValue(typeof(Color), "WindowFrame")]
        [Description("Color of the window border.")]
        public Color BorderColor { get; set; }

        [Category("Appearance"), DefaultValue(0)]
        [Description("Size of the window border.")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                headerHeight = value;
                borderSize = value;
            }
        }

        [Category("Buttons"), DefaultValue(typeof(Color), "WindowFrame")]
        [Description("Border color of the close and options buttons when the mouse is over them.")]
        public Color ButtonBorderColor { get; set; }

        [Category("Buttons"), DefaultValue(typeof(Color), "Highlight")]
        [Description("Background color of the close and options buttons when the mouse is over them.")]
        public Color ButtonHoverColor { get; set; }

        [Category("Content"), DefaultValue(typeof(Color), "HotTrack")]
        [Description("Color of the content text when the mouse is hovering over it.")]
        public Color ContentHoverColor { get; set; }

        [Category("Appearance"), DefaultValue(50)]
        [Description("Gradient of window background color.")]
        public int GradientPower { get; set; }

        [Category("Content")]
        [Description("Font of the content text.")]
        public Font ContentFont { get; set; }

        [Category("Title")]
        [Description("Font of the title.")]
        public Font TitleFont { get; set; }

        [Category("Image")]
        [Description("Size of the icon image.")]
        public Size ImageSize
        {
            get
            {
                if (imageSize.Width == 0)
                {
                    return Image?.Size ?? new Size(0, 0);
                }
                else
                {
                    return imageSize;
                }
            }
            set => imageSize = value;
        }

        public void ResetImageSize()
        {
            imageSize = Size.Empty;
        }

        public void UpdatePosition(int startPosition) => posStart = startPosition;
        private bool ShouldSerializeImageSize()
        {
            return !imageSize.Equals(Size.Empty);
        }

        private Size imageSize = new Size(0, 0);
        private int headerHeight;
        private int borderSize;
        private static object lockobj = new object();
        [Category("Image")]
        [Description("Icon image to display.")]
        public Image Image { get; set; }

        [Category("Header"), DefaultValue(true)]
        [Description("Whether to show a 'grip' image within the window header.")]
        public bool ShowGrip { get; set; }

        [Category("Behavior"), DefaultValue(true)]
        [Description("Whether to scroll the window or only fade it.")]
        public bool Scroll { get; set; }

        [Category("Behavior"), DefaultValue(false)]
        [Description("Do not show popup when running a program in full screen.")]
        public bool IgnoreWhenFullScreen { get; set; }

        public bool IsAnyPopupsStillVisible => positions.Any();

        [Category("Content")]
        [Description("Content text to display.")]
        public string ContentText { get; set; }

        [Category("Title")]
        [Description("Title text to display.")]
        public string TitleText { get; set; }

        [Category("Title")]
        [Description("Padding of title text.")]
        public Padding TitlePadding { get; set; }

        private void ResetTitlePadding()
        {
            TitlePadding = Padding.Empty;
        }

        private bool ShouldSerializeTitlePadding()
        {
            return !TitlePadding.Equals(Padding.Empty);
        }

        [Category("Content")]
        [Description("Padding of content text.")]
        public Padding ContentPadding { get; set; }

        private void ResetContentPadding()
        {
            ContentPadding = Padding.Empty;
        }

        private bool ShouldSerializeContentPadding()
        {
            return !ContentPadding.Equals(Padding.Empty);
        }

        [Category("Image")]
        [Description("Padding of icon image.")]
        public Padding ImagePadding { get; set; }

        private void ResetImagePadding()
        {
            ImagePadding = Padding.Empty;
        }

        private bool ShouldSerializeImagePadding()
        {
            return !ImagePadding.Equals(Padding.Empty);
        }

        [Category("Header"), DefaultValue(9)]
        [Description("Height of window header.")]
        public int HeaderHeight
        {
            get => headerHeight;
            set
            {
                if (value <= 0)
                {
                    value = 1;
                }

                headerHeight = value;
            }
        }

        [Category("Buttons"), DefaultValue(true)]
        [Description("Whether to show the close button.")]
        public bool ShowCloseButton { get; set; }

        [Category("Buttons"), DefaultValue(false)]
        [Description("Whether to show the options button.")]
        public bool ShowOptionsButton { get; set; }

        [Category("Behavior")]
        [Description("Context menu to open when clicking on the options button.")]
        public ContextMenuStrip OptionsMenu { get; set; }

        [Category("Behavior"), DefaultValue(3000)]
        [Description("Time in milliseconds the window is displayed.")]
        public int Delay { get; set; }

        [Category("Behavior"), DefaultValue(5000)]
        [Description("Time in milliseconds needed to make the window appear or disappear.")]
        public int AnimationDuration { get; set; }

        [Category("Behavior"), DefaultValue(10)]
        [Description("Interval in milliseconds used to draw the animation.")]
        public int AnimationInterval { get; set; }

        [Category("Appearance")]
        [Description("Size of the window.")]
        public Size Size { get; set; }

        [Category("Content")]
        [Description("Show Content Right To Left,نمایش پیغام چپ به راست فعال شود")]
        public bool IsRightToLeft { get; set; }

        [Category("Behavior"), DefaultValue(false)]
        [Description("boolean value indicates to use system sound on popup.")]
        public bool PlaySystemSoundOnPopup { get; set; }

        [Category("Behavior"), DefaultValue(10)]
        [Description("Type of system sound to use")]
        public SystemSoundType SystemSoundType { get; set; }
       
        [Category("Behavior"), DefaultValue("")]
        [Description("Custom system sound to use. File ath to sound file")]
        public string SystemSoundFilePath { get; set; }
        #endregion

        /// <summary>
        /// Create a new instance of the popup component.
        /// </summary>
        public PopupNotifier()
        {
               // set default values
            HeaderColor = SystemColors.ControlDark;
            BodyColor = SystemColors.Control;
            TitleColor = Color.Gray;
            ContentColor = SystemColors.ControlText;
            BorderColor = SystemColors.WindowFrame;
            ButtonBorderColor = SystemColors.WindowFrame;
            ButtonHoverColor = SystemColors.Highlight;
            ContentHoverColor = SystemColors.HotTrack;
            GradientPower = 50;
            ContentFont = SystemFonts.DialogFont;
            TitleFont = SystemFonts.CaptionFont;
            ShowGrip = true;
            Scroll = true;
            TitlePadding = new Padding(0);
            ContentPadding = new Padding(0);
            ImagePadding = new Padding(0);
            HeaderHeight = 9;
            ShowCloseButton = true;
            ShowOptionsButton = false;
            Delay = 3000;
            AnimationInterval = 10;
            AnimationDuration = 1000;
            Size = new Size(400, 100);

            CreateForm();
            tmrAnimation = new Timer();
            tmrAnimation.Tick += tmAnimation_Tick;

            tmrWait = new Timer();
            tmrWait.Tick += tmWait_Tick;
        }

        private void CreateForm()
        {
            frmPopup = new PopupNotifierForm(this)
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual
            };
            frmPopup.FormBorderStyle = FormBorderStyle.None;
            frmPopup.MouseEnter += frmPopup_MouseEnter;
            frmPopup.MouseLeave += frmPopup_MouseLeave;
            frmPopup.CloseClick += frmPopup_CloseClick;
            frmPopup.LinkClick += frmPopup_LinkClick;
            frmPopup.ContextMenuOpened += frmPopup_ContextMenuOpened;
            frmPopup.ContextMenuClosed += frmPopup_ContextMenuClosed;
            frmPopup.VisibleChanged += frmPopup_VisibleChanged;


        }


        private void SetNextPosition()
        {
            lock (lockobj)
            {
                int minimum = 0;
                positions = positions.OrderBy(i => i.index).ToList();
                foreach (var pos in positions)
                {
                    if (pos.index == minimum)
                    {
                        minimum = pos.index + 1;
                    }
                }

                currentIndex = minimum;
                if (minimum > 0)
                {
                    posStop = posStart = positions[currentIndex - 1].topPosition - frmPopup.Height;
                }
                if (minimum == 0)
                {
                    posStop = posStart = Screen.PrimaryScreen.WorkingArea.Bottom - frmPopup.Height;
                }

                positions.Insert(currentIndex, (currentIndex, posStart - BorderSize, this));
                Debug.WriteLine("insert: " + currentIndex + " (" + string.Join(",", positions.Select(i => i.index)) + ")");
                for (var index = 0; index < positions.Count; index++)
                {
                    (int index, int topPosition, PopupNotifier PopupNotifier) data = positions[index];
                    if (data.index > currentIndex)
                    {
                        var pos = positions[index - 1].topPosition - frmPopup.Height;
                        data.PopupNotifier.posStart = pos;
                        data.PopupNotifier.RePosition();
                    }
                }
            }
        }

        private void RePosition()
        {
            //frmPopup.Location=new Point(frmPopup.Location.X, posStart);
        }

        /// <summary>
        /// Show the notification window if it is not already visible.
        /// If the window is currently disappearing, it is shown again.
        /// </summary>
        public void Popup()
        {
            frmPopup.SetData();
            if (IgnoreWhenFullScreen && Utils.IsForegroundFullScreen())
            {
                return;
            }

            if (!disposed)
            {
                if (!frmPopup.Visible)
                {
                    PlaySoundIfNeeded();
                    if (frmPopup.IsDisposed)
                    {
                        CreateForm();
                    }

                    frmPopup.Size = Size;
                    SetNextPosition();
                    frmPopup.Closed += FrmPopup_Closed;
                    opacityStart = 0;
                    opacityStop = 1;

                    frmPopup.Opacity = opacityStart;
                    frmPopup.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - frmPopup.Size.Width - 1, posStart);
                    ShowInactiveTopmost(frmPopup);
                    isAppearing = true;

                    tmrWait.Interval = Delay;
                    tmrAnimation.Interval = AnimationInterval;
                    realAnimationDuration = AnimationDuration;
                    tmrAnimation.Start();
                    sw = System.Diagnostics.Stopwatch.StartNew();
                }
                else
                {
                    if (!isAppearing)
                    {
                        frmPopup.Size = Size;
                        //if (Scroll)
                        //{
                        //    posStart = frmPopup.Top;
                        //    posStop = Screen.PrimaryScreen.WorkingArea.Bottom - currentPosition * frmPopup.Height;
                        //}
                        //else
                        //{
                        //    posStart = Screen.PrimaryScreen.WorkingArea.Bottom - currentPosition * frmPopup.Height;
                        //    posStop = Screen.PrimaryScreen.WorkingArea.Bottom - currentPosition * frmPopup.Height;
                        //}
                        opacityStart = frmPopup.Opacity;
                        opacityStop = 1;
                        isAppearing = true;
                        realAnimationDuration = Math.Max((int)sw.ElapsedMilliseconds, 1);
                        sw.Restart();
                    }
                    frmPopup.Invalidate();
                }
            }
        }

        private void PlaySoundIfNeeded()
        {
            if (PlaySystemSoundOnPopup)
            {
                switch (SystemSoundType)
                {
                    case SystemSoundType.Asterisk:
                        System.Media.SystemSounds.Asterisk.Play();
                        break;
                    case SystemSoundType.Beep:
                        System.Media.SystemSounds.Beep.Play();
                        break;
                    case SystemSoundType.Exclamation:
                        System.Media.SystemSounds.Exclamation.Play();
                        break;
                    case SystemSoundType.Hand:
                        System.Media.SystemSounds.Hand.Play();
                        break;
                    case SystemSoundType.Question:
                        System.Media.SystemSounds.Question.Play();
                        break;
                    case SystemSoundType.Notification:
                        try
                        {
                            try
                            {
                                using (RegistryKey key =
                                    Registry.CurrentUser.OpenSubKey(
                                        @"AppEvents\Schemes\Apps\.Default\Notification.Default\.Current"))
                                {
                                    object o = key?.GetValue(null); // pass null to get (Default)
                                    if (o != null)
                                    {
                                        using (SoundPlayer theSound = new SoundPlayer((string) o))
                                        {
                                            theSound.Play();
                                        }
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"unable to play notification sound:{e.Message}");
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case SystemSoundType.Custom:
                        if (File.Exists(SystemSoundFilePath) && Path.GetExtension(SystemSoundFilePath)
                            .EndsWith("wav", StringComparison.InvariantCultureIgnoreCase))
                        {
                            using (SoundPlayer theSound = new SoundPlayer(SystemSoundFilePath))
                            {
                                theSound.Play();
                            }

                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }}

        private void FrmPopup_Closed(object sender, EventArgs e)
        {
            frmPopup.Closed -= FrmPopup_Closed;
            lock (lockobj)
            {
                Debug.WriteLine("remove: " + currentIndex);
                var item = positions.First(i => i.index == currentIndex);
                positions.Remove(item);
            }
        }

        /// <summary>
        /// Hide the notification window.
        /// </summary>
        public void Hide()
        {
            tmrAnimation.Stop();
            tmrWait.Stop();
            frmPopup.Close();
            if (markedForDisposed)
            {
                Dispose();
            }
        }

        /// <summary>
        /// The custom options menu has been closed. Restart the timer for
        /// closing the notification window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopup_ContextMenuClosed(object sender, EventArgs e)
        {
            if (!mouseIsOn)
            {
                tmrWait.Interval = Delay;
                tmrWait.Start();
            }
        }


        /// <summary>
        /// The custom options menu has been opened. The window must not be closed
        /// as long as the menu is open.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopup_ContextMenuOpened(object sender, EventArgs e)
        {
            tmrWait.Stop();
        }

        /// <summary>
        /// The text has been clicked. Raise the 'Click' event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopup_LinkClick(object sender, EventArgs e)
        {
            Click?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// The close button has been clicked. Hide the notification window
        /// and raise the 'Close' event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopup_CloseClick(object sender, EventArgs e)
        {
            Hide();
            Close?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Visibility has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopup_VisibleChanged(object sender, EventArgs e)
        {
            if (frmPopup.Visible)
            {
                Appear?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Disappear?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Update form position and opacity to show/hide the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmAnimation_Tick(object sender, EventArgs e)
        {
            if (Utils.IdleTime().TotalSeconds > 30)
            {
                return;
            }
            long elapsed = sw.ElapsedMilliseconds;

            int posCurrent = (int)(posStart + (posStop - posStart) * elapsed / realAnimationDuration);
            bool neg = posStop - posStart < 0;
            if (neg && posCurrent < posStop ||
                !neg && posCurrent > posStop)
            {
                posCurrent = posStop;
            }

            double opacityCurrent = opacityStart + (opacityStop - opacityStart) * elapsed / realAnimationDuration;
            neg = opacityStop - opacityStart < 0;
            if (neg && opacityCurrent < opacityStop ||
                !neg && opacityCurrent > opacityStop)
            {
                opacityCurrent = opacityStop;
            }

            frmPopup.Top = posCurrent;
            frmPopup.Opacity = opacityCurrent;

            // animation has ended
            if (elapsed > realAnimationDuration)
            {

                sw.Reset();
                tmrAnimation.Stop();

                if (isAppearing)
                {
                    if (Scroll)
                    {
                        posStart = Screen.PrimaryScreen.WorkingArea.Bottom - frmPopup.Height;
                        posStop = Screen.PrimaryScreen.WorkingArea.Bottom;
                    }
                    else
                    {
                        posStart = Screen.PrimaryScreen.WorkingArea.Bottom - frmPopup.Height;
                        posStop = Screen.PrimaryScreen.WorkingArea.Bottom - frmPopup.Height;
                    }
                    opacityStart = 1;
                    opacityStop = 0;

                    realAnimationDuration = AnimationDuration;

                    isAppearing = false;
                    maxPosition = frmPopup.Top;
                    maxOpacity = frmPopup.Opacity;
                    if (!mouseIsOn)
                    {
                        tmrWait.Stop();
                        tmrWait.Start();
                    }
                }
                else
                {
                    frmPopup.Close();
                    if (markedForDisposed)
                    {
                        Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// The wait timer has elapsed, start the animation to hide the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmWait_Tick(object sender, EventArgs e)
        {
            tmrWait.Stop();
            tmrAnimation.Interval = AnimationInterval;
            tmrAnimation.Start();
            sw.Restart();
        }

        /// <summary>
        /// Start wait timer if the mouse leaves the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopup_MouseLeave(object sender, EventArgs e)
        {
            if (frmPopup.Visible && (OptionsMenu == null || !OptionsMenu.Visible))
            {
                tmrWait.Interval = Delay;
                tmrWait.Start();
            }
            mouseIsOn = false;
        }

        /// <summary>
        /// Stop wait timer if the mouse enters the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPopup_MouseEnter(object sender, EventArgs e)
        {
            if (!isAppearing)
            {
                frmPopup.Top = maxPosition;
                frmPopup.Opacity = maxOpacity;
                tmrAnimation.Stop();
            }

            tmrWait.Stop();
            mouseIsOn = true;
        }

        /// <summary>
        /// Dispose the notification form.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (isAppearing)
                {
                    markedForDisposed = true;
                    return;
                }

                if (disposing)
                {
                    frmPopup?.Dispose();
                    tmrAnimation.Tick -= tmAnimation_Tick;
                    tmrWait.Tick -= tmWait_Tick;
                    tmrAnimation.Dispose();
                    tmrWait.Dispose();
                }
                disposed = true;
            }
            base.Dispose(disposing);
        }
    }
}
