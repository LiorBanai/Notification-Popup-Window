﻿namespace DemoApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.chkIcon = new System.Windows.Forms.CheckBox();
            this.chkClose = new System.Windows.Forms.CheckBox();
            this.chkMenu = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.chkGrip = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaddingIcon = new System.Windows.Forms.TextBox();
            this.chkScroll = new System.Windows.Forms.CheckBox();
            this.txtPaddingContent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaddingTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnimationDuration = new System.Windows.Forms.TextBox();
            this.chkIsRightToLeft = new System.Windows.Forms.CheckBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblColorValue = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTextColor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBorder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHeaderHeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(852, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(10, 270);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show!";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(48, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(280, 24);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "Notification Title";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(49, 40);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(279, 24);
            this.txtText.TabIndex = 5;
            this.txtText.Text = "This is the notification text!";
            // 
            // chkIcon
            // 
            this.chkIcon.AutoSize = true;
            this.chkIcon.Checked = true;
            this.chkIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIcon.Location = new System.Drawing.Point(15, 113);
            this.chkIcon.Name = "chkIcon";
            this.chkIcon.Size = new System.Drawing.Size(93, 21);
            this.chkIcon.TabIndex = 6;
            this.chkIcon.Text = "Show icon";
            this.chkIcon.UseVisualStyleBackColor = true;
            // 
            // chkClose
            // 
            this.chkClose.AutoSize = true;
            this.chkClose.Checked = true;
            this.chkClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClose.Location = new System.Drawing.Point(15, 136);
            this.chkClose.Name = "chkClose";
            this.chkClose.Size = new System.Drawing.Size(144, 21);
            this.chkClose.TabIndex = 7;
            this.chkClose.Text = "Show close button";
            this.chkClose.UseVisualStyleBackColor = true;
            // 
            // chkMenu
            // 
            this.chkMenu.AutoSize = true;
            this.chkMenu.Checked = true;
            this.chkMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMenu.Location = new System.Drawing.Point(15, 160);
            this.chkMenu.Name = "chkMenu";
            this.chkMenu.Size = new System.Drawing.Size(146, 21);
            this.chkMenu.TabIndex = 8;
            this.chkMenu.Text = "Show option menu";
            this.chkMenu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Delay [ms]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Animation interval [ms]:";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(514, 107);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(100, 24);
            this.txtDelay.TabIndex = 11;
            this.txtDelay.Text = "3000";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(514, 133);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 24);
            this.txtInterval.TabIndex = 12;
            this.txtInterval.Text = "10";
            // 
            // chkGrip
            // 
            this.chkGrip.AutoSize = true;
            this.chkGrip.Checked = true;
            this.chkGrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGrip.Location = new System.Drawing.Point(15, 185);
            this.chkGrip.Name = "chkGrip";
            this.chkGrip.Size = new System.Drawing.Size(91, 21);
            this.chkGrip.TabIndex = 13;
            this.chkGrip.Text = "Show grip";
            this.chkGrip.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Title padding [px]:";
            // 
            // txtPaddingIcon
            // 
            this.txtPaddingIcon.Location = new System.Drawing.Point(514, 237);
            this.txtPaddingIcon.Name = "txtPaddingIcon";
            this.txtPaddingIcon.Size = new System.Drawing.Size(100, 24);
            this.txtPaddingIcon.TabIndex = 15;
            this.txtPaddingIcon.Text = "0";
            // 
            // chkScroll
            // 
            this.chkScroll.AutoSize = true;
            this.chkScroll.Checked = true;
            this.chkScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScroll.Location = new System.Drawing.Point(15, 211);
            this.chkScroll.Name = "chkScroll";
            this.chkScroll.Size = new System.Drawing.Size(102, 21);
            this.chkScroll.TabIndex = 16;
            this.chkScroll.Text = "Scroll in/out";
            this.chkScroll.UseVisualStyleBackColor = true;
            // 
            // txtPaddingContent
            // 
            this.txtPaddingContent.Location = new System.Drawing.Point(514, 211);
            this.txtPaddingContent.Name = "txtPaddingContent";
            this.txtPaddingContent.Size = new System.Drawing.Size(100, 24);
            this.txtPaddingContent.TabIndex = 17;
            this.txtPaddingContent.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Icon padding [px]:";
            // 
            // txtPaddingTitle
            // 
            this.txtPaddingTitle.Location = new System.Drawing.Point(514, 185);
            this.txtPaddingTitle.Name = "txtPaddingTitle";
            this.txtPaddingTitle.Size = new System.Drawing.Size(100, 24);
            this.txtPaddingTitle.TabIndex = 19;
            this.txtPaddingTitle.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Content padding [px]:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 76);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.settingsToolStripMenuItem.Text = "Settings...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "AnimationDuration [ms]:";
            // 
            // txtAnimationDuration
            // 
            this.txtAnimationDuration.Location = new System.Drawing.Point(514, 159);
            this.txtAnimationDuration.Name = "txtAnimationDuration";
            this.txtAnimationDuration.Size = new System.Drawing.Size(100, 24);
            this.txtAnimationDuration.TabIndex = 22;
            this.txtAnimationDuration.Text = "1000";
            // 
            // chkIsRightToLeft
            // 
            this.chkIsRightToLeft.AutoSize = true;
            this.chkIsRightToLeft.Location = new System.Drawing.Point(15, 237);
            this.chkIsRightToLeft.Name = "chkIsRightToLeft";
            this.chkIsRightToLeft.Size = new System.Drawing.Size(292, 21);
            this.chkIsRightToLeft.TabIndex = 23;
            this.chkIsRightToLeft.Text = "Right to Left/ راست به چپ \\ מימין לשמאל";
            this.chkIsRightToLeft.UseVisualStyleBackColor = true;
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.Location = new System.Drawing.Point(772, 270);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(153, 23);
            this.btnMore.TabIndex = 24;
            this.btnMore.Text = "Multiple Popups";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(348, 17);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 17);
            this.lblColor.TabIndex = 25;
            this.lblColor.Text = "Color:";
            // 
            // lblColorValue
            // 
            this.lblColorValue.AutoSize = true;
            this.lblColorValue.BackColor = System.Drawing.Color.Black;
            this.lblColorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorValue.ForeColor = System.Drawing.Color.Transparent;
            this.lblColorValue.Location = new System.Drawing.Point(402, 17);
            this.lblColorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColorValue.Name = "lblColorValue";
            this.lblColorValue.Size = new System.Drawing.Size(26, 19);
            this.lblColorValue.TabIndex = 26;
            this.lblColorValue.Text = "    ";
            this.lblColorValue.Click += new System.EventHandler(this.lblColorValue_Click);
            // 
            // lblTextColor
            // 
            this.lblTextColor.AutoSize = true;
            this.lblTextColor.BackColor = System.Drawing.Color.Black;
            this.lblTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTextColor.ForeColor = System.Drawing.Color.Transparent;
            this.lblTextColor.Location = new System.Drawing.Point(402, 46);
            this.lblTextColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextColor.Name = "lblTextColor";
            this.lblTextColor.Size = new System.Drawing.Size(26, 19);
            this.lblTextColor.TabIndex = 28;
            this.lblTextColor.Text = "    ";
            this.lblTextColor.Click += new System.EventHandler(this.lblTextColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Color:";
            // 
            // txtBorder
            // 
            this.txtBorder.Location = new System.Drawing.Point(825, 106);
            this.txtBorder.Name = "txtBorder";
            this.txtBorder.Size = new System.Drawing.Size(100, 24);
            this.txtBorder.TabIndex = 29;
            this.txtBorder.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(631, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Border Size (zero or positive):";
            // 
            // txtHeaderHeight
            // 
            this.txtHeaderHeight.Location = new System.Drawing.Point(825, 134);
            this.txtHeaderHeight.Name = "txtHeaderHeight";
            this.txtHeaderHeight.Size = new System.Drawing.Size(100, 24);
            this.txtHeaderHeight.TabIndex = 31;
            this.txtHeaderHeight.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(631, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Header Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 302);
            this.Controls.Add(this.txtHeaderHeight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBorder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTextColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblColorValue);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.chkIsRightToLeft);
            this.Controls.Add(this.txtPaddingTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAnimationDuration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkScroll);
            this.Controls.Add(this.txtPaddingContent);
            this.Controls.Add(this.txtPaddingIcon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkGrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkMenu);
            this.Controls.Add(this.chkClose);
            this.Controls.Add(this.chkIcon);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NotificationWindow Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.CheckBox chkIcon;
        private System.Windows.Forms.CheckBox chkClose;
        private System.Windows.Forms.CheckBox chkMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.CheckBox chkGrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaddingIcon;
        private System.Windows.Forms.CheckBox chkScroll;
        private System.Windows.Forms.TextBox txtPaddingContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPaddingTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnimationDuration;
        private NotificationWindow.PopupNotifier popupNotifier1;
        private System.Windows.Forms.CheckBox chkIsRightToLeft;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblColorValue;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTextColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBorder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHeaderHeight;
        private System.Windows.Forms.Label label11;
    }
}

