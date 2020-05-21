/*
 *	Created/modified in 2011 by Simon Baer
 *	
 *  Licensed under the Code Project Open License (CPOL).
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using NotificationWindow;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            popupNotifier1.TitleText = txtTitle.Text;
            popupNotifier1.ContentText = txtText.Text;
            popupNotifier1.ShowCloseButton = chkClose.Checked;
            popupNotifier1.ShowOptionsButton = chkMenu.Checked;
            popupNotifier1.ShowGrip = chkGrip.Checked;
            popupNotifier1.Delay = int.Parse(txtDelay.Text);
            popupNotifier1.AnimationInterval = int.Parse(txtInterval.Text);
            popupNotifier1.AnimationDuration = int.Parse(txtAnimationDuration.Text);
            popupNotifier1.TitlePadding = new Padding(int.Parse(txtPaddingTitle.Text));
            popupNotifier1.ContentPadding = new Padding(int.Parse(txtPaddingContent.Text));
            popupNotifier1.ImagePadding = new Padding(int.Parse(txtPaddingIcon.Text));
            popupNotifier1.Scroll = chkScroll.Checked;
            popupNotifier1.IsRightToLeft = chkIsRightToLeft.Checked;
            popupNotifier1.Image = chkIcon.Checked ? Properties.Resources._157_GetPermission_48x48_72 : null;

            popupNotifier1.Popup();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            var popupNotifier2 = new PopupNotifier();
            popupNotifier2.TitleText = txtTitle.Text;
            popupNotifier2.ContentText = txtText.Text;
            popupNotifier2.ShowCloseButton = chkClose.Checked;
            popupNotifier2.ShowOptionsButton = chkMenu.Checked;
            popupNotifier2.ShowGrip = chkGrip.Checked;
            popupNotifier2.Delay = int.Parse(txtDelay.Text);
            popupNotifier2.AnimationInterval = int.Parse(txtInterval.Text);
            popupNotifier2.AnimationDuration = int.Parse(txtAnimationDuration.Text);
            popupNotifier2.TitlePadding = new Padding(int.Parse(txtPaddingTitle.Text));
            popupNotifier2.ContentPadding = new Padding(int.Parse(txtPaddingContent.Text));
            popupNotifier2.ImagePadding = new Padding(int.Parse(txtPaddingIcon.Text));
            popupNotifier2.Scroll = chkScroll.Checked;
            popupNotifier2.IsRightToLeft = chkIsRightToLeft.Checked;
            popupNotifier2.Image = chkIcon.Checked ? Properties.Resources._157_GetPermission_48x48_72 : null;

            popupNotifier2.Popup();
        }
    }
}
