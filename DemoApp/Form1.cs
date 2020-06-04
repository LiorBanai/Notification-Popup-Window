/*
 *	Created/modified in 2011 by Simon Baer
 *	
 *  Licensed under the Code Project Open License (CPOL).
 */

using DemoApp.Properties;
using NotificationWindow;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            popupNotifier1.Image = chkIcon.Checked ? Resources._157_GetPermission_48x48_72 : null;
            popupNotifier1.ContentColor = lblTextColor.BackColor;
            popupNotifier1.TitleColor = lblColorValue.BackColor;
            popupNotifier1.Popup();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            using (var popupNotifier2 = new PopupNotifier())
            {
                popupNotifier2.BodyColor = Color.FromArgb(128, 128, 255);
                popupNotifier2.ContentFont = new Font("Tahoma", 8F);
                popupNotifier2.ContentText = null;
                popupNotifier2.GradientPower = 300;
                popupNotifier2.HeaderHeight = 20;
                popupNotifier2.Image = null;
                popupNotifier2.IsRightToLeft = false;
                popupNotifier2.OptionsMenu = contextMenuStrip1;
                popupNotifier2.Size = new Size(400, 100);
                popupNotifier2.TitleFont = new Font("Segoe UI", 9F);
                popupNotifier2.TitleText = null;
                popupNotifier2.TitleText = txtTitle.Text;
                popupNotifier2.ContentText = txtText.Text;
                popupNotifier2.GradientPower = 300;
                popupNotifier2.HeaderHeight = 20;
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
                popupNotifier2.Image = chkIcon.Checked ? Resources._157_GetPermission_48x48_72 : null;
                popupNotifier2.ContentColor = lblTextColor.BackColor;
                popupNotifier2.TitleColor = lblColorValue.BackColor;
                popupNotifier2.Popup();
            }
        }

        private void lblColorValue_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblColorValue.BackColor = colorDialog1.Color;
            }
        }

        private void lblTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblTextColor.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popupNotifier1 = new PopupNotifier();
        }
    }
}
