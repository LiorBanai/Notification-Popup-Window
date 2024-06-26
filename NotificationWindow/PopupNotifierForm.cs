﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NotificationWindow
{
    /// <summary>
    /// This is the form of the actual notification window.
    /// </summary>
    internal class PopupNotifierForm : Form
    {
        /// <summary>
        /// Event that is raised when the text is clicked.
        /// </summary>
        public event EventHandler LinkClick;

        /// <summary>
        /// Event that is raised when the notification window is manually closed.
        /// </summary>
        public event EventHandler CloseClick;

        internal event EventHandler ContextMenuOpened;
        internal event EventHandler ContextMenuClosed;

        private bool mouseOnClose;
        private bool mouseOnLink;
        private bool mouseOnOptions;
        private int heightOfTitle;

        #region GDI objects

        private bool gdiInitialized;
        private Rectangle rcBody;
        private Rectangle rcHeader;
        private Rectangle rcForm;
        private LinearGradientBrush brushBody;
        private LinearGradientBrush brushHeader;
        private Brush brushButtonHover;
        private Pen penButtonBorder;
        private Pen penContent;
        private Pen penBorder;
        private Brush brushForeColor;
        private Brush brushLinkHover;
        private Brush brushContent;
        private Brush brushTitle;

        #endregion

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="parent">PopupNotifier</param>
        public PopupNotifierForm(PopupNotifier parent)
        {
            Parent = parent;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            ShowInTaskbar = false;

            VisibleChanged += PopupNotifierForm_VisibleChanged;
            MouseMove += PopupNotifierForm_MouseMove;
            MouseUp += PopupNotifierForm_MouseUp;
            Paint += PopupNotifierForm_Paint;
        }

        /// <summary>
        /// The form is shown/hidden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopupNotifierForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                mouseOnClose = false;
                mouseOnLink = false;
                mouseOnOptions = false;
            }
        }

        /// <summary>
        /// Used in design mode.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            ClientSize = new Size(392, 66);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopupNotifierForm";
            StartPosition = FormStartPosition.Manual;
            ResumeLayout(false);
        }

        /// <summary>
        /// Gets or sets the parent control.
        /// </summary>
        public new PopupNotifier Parent { get; set; }

        /// <summary>
        /// Add two values but do not return a value greater than 255.
        /// </summary>
        /// <param name="input">first value</param>
        /// <param name="add">value to add</param>
        /// <returns>sum of both values</returns>
        private int AddValueMax255(int input, int add)
        {
            return (input + add < 256) ? input + add : 255;
        }

        /// <summary>
        /// Subtract two values but do not returns a value below 0.
        /// </summary>
        /// <param name="input">first value</param>
        /// <param name="ded">value to subtract</param>
        /// <returns>first value minus second value</returns>
        private int DedValueMin0(int input, int ded)
        {
            return (input - ded > 0) ? input - ded : 0;
        }

        /// <summary>
        /// Returns a color which is darker than the given color.
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>darker color</returns>
        private Color GetDarkerColor(Color color)
        {
            return Color.FromArgb(255, DedValueMin0((int)color.R, Parent.GradientPower), DedValueMin0((int)color.G, Parent.GradientPower), DedValueMin0((int)color.B, Parent.GradientPower));
        }

        /// <summary>
        /// Returns a color which is lighter than the given color.
        /// </summary>
        /// <param name="color">Color</param>
        /// <returns>lighter color</returns>
        private Color GetLighterColor(Color color)
        {
            return Color.FromArgb(255, AddValueMax255((int)color.R, Parent.GradientPower), AddValueMax255((int)color.G, Parent.GradientPower), AddValueMax255((int)color.B, Parent.GradientPower));
        }

        /// <summary>
        /// Gets the rectangle of the content text.
        /// </summary>
        private RectangleF RectContentText
        {
            get
            {
                if (Parent.Image != null)
                {
                    return new RectangleF(
                        Parent.ImagePadding.Left + Parent.ImageSize.Width + Parent.ImagePadding.Right + Parent.ContentPadding.Left,
                        Parent.HeaderHeight + Parent.TitlePadding.Top + heightOfTitle + Parent.TitlePadding.Bottom + Parent.ContentPadding.Top,
                        Width - Parent.ImagePadding.Left - Parent.ImageSize.Width - Parent.ImagePadding.Right - Parent.ContentPadding.Left - Parent.ContentPadding.Right - 16 - 5,
                        Height - Parent.HeaderHeight - Parent.TitlePadding.Top - heightOfTitle - Parent.TitlePadding.Bottom - Parent.ContentPadding.Top - Parent.ContentPadding.Bottom - 1);
                }
                else
                {
                    return new RectangleF(
                        Parent.ContentPadding.Left,
                        Parent.HeaderHeight + Parent.TitlePadding.Top + heightOfTitle + Parent.TitlePadding.Bottom + Parent.ContentPadding.Top,
                        Width - Parent.ContentPadding.Left - Parent.ContentPadding.Right - 16 - 5,
                        Height - Parent.HeaderHeight - Parent.TitlePadding.Top - heightOfTitle - Parent.TitlePadding.Bottom - Parent.ContentPadding.Top - Parent.ContentPadding.Bottom - 1);
                }
            }
        }

        /// <summary>
        /// gets the rectangle of the close button.
        /// </summary>
        private Rectangle RectClose
        {
            get { return new Rectangle(Width - 5 - 16, Parent.HeaderHeight + 3, 16, 16); }
        }

        /// <summary>
        /// Gets the rectangle of the options button.
        /// </summary>
        private Rectangle RectOptions
        {
            get { return new Rectangle(Width - 5 - 16, Parent.HeaderHeight + 3 + 16 + 5, 16, 16); }
        }

        /// <summary>
        /// Update form to display hover styles when the mouse moves over the notification form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopupNotifierForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Parent.ShowCloseButton)
            {
                mouseOnClose = RectClose.Contains(e.X, e.Y);
            }
            if (Parent.ShowOptionsButton)
            {
                mouseOnOptions = RectOptions.Contains(e.X, e.Y);
            }
            mouseOnLink = RectContentText.Contains(e.X, e.Y);
            Invalidate();
        }

        /// <summary>
        /// A mouse button has been released, check if something has been clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopupNotifierForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RectClose.Contains(e.X, e.Y))
                {
                    CloseClick?.Invoke(this, EventArgs.Empty);
                }
                if (RectContentText.Contains(e.X, e.Y))
                {
                    LinkClick?.Invoke(this, EventArgs.Empty);
                }
                if (RectOptions.Contains(e.X, e.Y) && (Parent.OptionsMenu != null))
                {
                    ContextMenuOpened?.Invoke(this, EventArgs.Empty);
                    Parent.OptionsMenu.Show(this, new Point(RectOptions.Right - Parent.OptionsMenu.Width, RectOptions.Bottom));
                    Parent.OptionsMenu.Closed += OptionsMenu_Closed;
                }
            }
        }

        /// <summary>
        /// The options popup menu has been closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            Parent.OptionsMenu.Closed -= OptionsMenu_Closed;

            ContextMenuClosed?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Create all GDI objects used to paint the form.
        /// </summary>
        private void AllocateGDIObjects()
        {
            rcBody = new Rectangle(0, 0, Width, Height);
            rcHeader = new Rectangle(0, 0, Width, Parent.HeaderHeight);
            rcForm = new Rectangle(0, 0, Width - 1, Height - 1);

            brushBody = new LinearGradientBrush(rcBody, Parent.BodyColor, GetLighterColor(Parent.BodyColor), LinearGradientMode.Vertical);
            brushHeader = new LinearGradientBrush(rcHeader, Parent.HeaderColor, GetDarkerColor(Parent.HeaderColor), LinearGradientMode.Vertical);
            brushButtonHover = new SolidBrush(Parent.ButtonHoverColor);
            penButtonBorder = new Pen(Parent.ButtonBorderColor);
            penContent = new Pen(Parent.ContentColor, 2);
            penBorder = new Pen(Parent.BorderColor);
            brushForeColor = new SolidBrush(ForeColor);
            brushLinkHover = new SolidBrush(Parent.ContentHoverColor);
            brushContent = new SolidBrush(Parent.ContentColor);
            brushTitle = new SolidBrush(Parent.TitleColor);

            gdiInitialized = true;
        }

        /// <summary>
        /// Free all GDI objects.
        /// </summary>
        private void DisposeGDIObjects()
        {
            if (gdiInitialized)
            {
                brushBody.Dispose();
                brushHeader.Dispose();
                brushButtonHover.Dispose();
                penButtonBorder.Dispose();
                penContent.Dispose();
                penBorder.Dispose();
                brushForeColor.Dispose();
                brushLinkHover.Dispose();
                brushContent.Dispose();
                brushTitle.Dispose();
            }
        }

        /// <summary>
        /// Draw the notification form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopupNotifierForm_Paint(object sender, PaintEventArgs e)
        {
            if (!gdiInitialized)
            {
                AllocateGDIObjects();
            }

            // draw window
            e.Graphics.FillRectangle(brushBody, rcBody);
            e.Graphics.FillRectangle(brushHeader, rcHeader);
            e.Graphics.DrawRectangle(penBorder, rcForm);
            if (Parent.ShowGrip)
            {
                e.Graphics.DrawImage(Properties.Resources.Grip, (int)((Width - Properties.Resources.Grip.Width) / 2), (int)((Parent.HeaderHeight - 3) / 2));
            }
            if (Parent.ShowCloseButton)
            {
                if (mouseOnClose)
                {
                    e.Graphics.FillRectangle(brushButtonHover, RectClose);
                    e.Graphics.DrawRectangle(penButtonBorder, RectClose);
                }
                e.Graphics.DrawLine(penContent, RectClose.Left + 4, RectClose.Top + 4, RectClose.Right - 4, RectClose.Bottom - 4);
                e.Graphics.DrawLine(penContent, RectClose.Left + 4, RectClose.Bottom - 4, RectClose.Right - 4, RectClose.Top + 4);
            }
            if (Parent.ShowOptionsButton)
            {
                if (mouseOnOptions)
                {
                    e.Graphics.FillRectangle(brushButtonHover, RectOptions);
                    e.Graphics.DrawRectangle(penButtonBorder, RectOptions);
                }
                e.Graphics.FillPolygon(brushForeColor, new Point[] { new Point(RectOptions.Left + 4, RectOptions.Top + 6), new Point(RectOptions.Left + 12, RectOptions.Top + 6), new Point(RectOptions.Left + 8, RectOptions.Top + 4 + 6) });
            }

            // draw icon
            if (Parent.Image != null)
            {
                e.Graphics.DrawImage(Parent.Image, Parent.ImagePadding.Left, Parent.HeaderHeight + Parent.ImagePadding.Top, Parent.ImageSize.Width, Parent.ImageSize.Height);
            }

            if (Parent.IsRightToLeft)
            {
                heightOfTitle = (int)e.Graphics.MeasureString("A", Parent.TitleFont).Height;

                // the value 30 is because of x close icon
                int titleX2 = Width - 30;// Parent.TitlePadding.Right;

                // draw title right to left
                StringFormat headerFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
                e.Graphics.DrawString(Parent.TitleText, Parent.TitleFont, brushTitle, titleX2, Parent.HeaderHeight + Parent.TitlePadding.Top, headerFormat);

                // draw content text, optionally with a bold part
                Cursor = mouseOnLink ? Cursors.Hand : Cursors.Default;
                Brush brushText = mouseOnLink ? brushLinkHover : brushContent;

                // draw content right to left
                StringFormat contentFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
                e.Graphics.DrawString(Parent.ContentText, Parent.ContentFont, brushText, RectContentText, contentFormat);
            }
            else
            {
                // calculate height of title
                heightOfTitle = (int)e.Graphics.MeasureString("A", Parent.TitleFont).Height;
                int titleX = Parent.TitlePadding.Left;
                if (Parent.Image != null)
                {
                    titleX += Parent.ImagePadding.Left + Parent.ImageSize.Width + Parent.ImagePadding.Right;
                }

                e.Graphics.DrawString(Parent.TitleText, Parent.TitleFont, brushTitle, titleX, Parent.HeaderHeight + Parent.TitlePadding.Top);

                // draw content text, optionally with a bold part
                Cursor = mouseOnLink ? Cursors.Hand : Cursors.Default;
                Brush brushText = mouseOnLink ? brushLinkHover : brushContent;
                e.Graphics.DrawString(Parent.ContentText, Parent.ContentFont, brushText, RectContentText);
            }
        }

        /// <summary>
        /// Dispose GDI objects.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DisposeGDIObjects();
            }
            base.Dispose(disposing);
        }
    }
}