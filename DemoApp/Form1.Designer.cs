namespace DemoApp
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
            components = new System.ComponentModel.Container();
            btnExit = new System.Windows.Forms.Button();
            btnShow = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            txtText = new System.Windows.Forms.TextBox();
            chkIcon = new System.Windows.Forms.CheckBox();
            chkClose = new System.Windows.Forms.CheckBox();
            chkMenu = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtDelay = new System.Windows.Forms.TextBox();
            txtInterval = new System.Windows.Forms.TextBox();
            chkGrip = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            txtPaddingIcon = new System.Windows.Forms.TextBox();
            chkScroll = new System.Windows.Forms.CheckBox();
            txtPaddingContent = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtPaddingTitle = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label8 = new System.Windows.Forms.Label();
            txtAnimationDuration = new System.Windows.Forms.TextBox();
            chkIsRightToLeft = new System.Windows.Forms.CheckBox();
            btnMore = new System.Windows.Forms.Button();
            lblColor = new System.Windows.Forms.Label();
            lblColorValue = new System.Windows.Forms.Label();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            lblTextColor = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtBorder = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtHeaderHeight = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            gbSound = new System.Windows.Forms.GroupBox();
            btnOpemSoundFile = new System.Windows.Forms.Button();
            txtSoundPath = new System.Windows.Forms.TextBox();
            rbCustom = new System.Windows.Forms.RadioButton();
            rbNotification = new System.Windows.Forms.RadioButton();
            rbHand = new System.Windows.Forms.RadioButton();
            rbQuestion = new System.Windows.Forms.RadioButton();
            rbExclamation = new System.Windows.Forms.RadioButton();
            rbBeep = new System.Windows.Forms.RadioButton();
            rbAsterisk = new System.Windows.Forms.RadioButton();
            chkbSound = new System.Windows.Forms.CheckBox();
            chkbAutoHeight = new System.Windows.Forms.CheckBox();
            chkbPopupRelative = new System.Windows.Forms.CheckBox();
            gbLocation = new System.Windows.Forms.GroupBox();
            rbTopLeft = new System.Windows.Forms.RadioButton();
            rbBottomRight = new System.Windows.Forms.RadioButton();
            rbTopRight = new System.Windows.Forms.RadioButton();
            rbBottomLeft = new System.Windows.Forms.RadioButton();
            contextMenuStrip1.SuspendLayout();
            gbSound.SuspendLayout();
            gbLocation.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExit.Location = new System.Drawing.Point(991, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnShow
            // 
            btnShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnShow.Location = new System.Drawing.Point(12, 340);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(75, 23);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show!";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 17);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 17);
            label2.TabIndex = 3;
            label2.Text = "Text:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(48, 14);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(280, 24);
            txtTitle.TabIndex = 4;
            txtTitle.Text = "Notification Title";
            // 
            // txtText
            // 
            txtText.Location = new System.Drawing.Point(49, 40);
            txtText.Name = "txtText";
            txtText.Size = new System.Drawing.Size(279, 24);
            txtText.TabIndex = 5;
            txtText.Text = "This is the notification text!";
            // 
            // chkIcon
            // 
            chkIcon.AutoSize = true;
            chkIcon.Checked = true;
            chkIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIcon.Location = new System.Drawing.Point(15, 77);
            chkIcon.Name = "chkIcon";
            chkIcon.Size = new System.Drawing.Size(93, 21);
            chkIcon.TabIndex = 6;
            chkIcon.Text = "Show icon";
            chkIcon.UseVisualStyleBackColor = true;
            // 
            // chkClose
            // 
            chkClose.AutoSize = true;
            chkClose.Checked = true;
            chkClose.CheckState = System.Windows.Forms.CheckState.Checked;
            chkClose.Location = new System.Drawing.Point(15, 100);
            chkClose.Name = "chkClose";
            chkClose.Size = new System.Drawing.Size(144, 21);
            chkClose.TabIndex = 7;
            chkClose.Text = "Show close button";
            chkClose.UseVisualStyleBackColor = true;
            // 
            // chkMenu
            // 
            chkMenu.AutoSize = true;
            chkMenu.Checked = true;
            chkMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            chkMenu.Location = new System.Drawing.Point(15, 124);
            chkMenu.Name = "chkMenu";
            chkMenu.Size = new System.Drawing.Size(146, 21);
            chkMenu.TabIndex = 8;
            chkMenu.Text = "Show option menu";
            chkMenu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(320, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 17);
            label4.TabIndex = 9;
            label4.Text = "Delay [ms]:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(320, 101);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 17);
            label3.TabIndex = 10;
            label3.Text = "Animation interval [ms]:";
            // 
            // txtDelay
            // 
            txtDelay.Location = new System.Drawing.Point(514, 71);
            txtDelay.Name = "txtDelay";
            txtDelay.Size = new System.Drawing.Size(100, 24);
            txtDelay.TabIndex = 11;
            txtDelay.Text = "3000";
            // 
            // txtInterval
            // 
            txtInterval.Location = new System.Drawing.Point(514, 97);
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new System.Drawing.Size(100, 24);
            txtInterval.TabIndex = 12;
            txtInterval.Text = "10";
            // 
            // chkGrip
            // 
            chkGrip.AutoSize = true;
            chkGrip.Checked = true;
            chkGrip.CheckState = System.Windows.Forms.CheckState.Checked;
            chkGrip.Location = new System.Drawing.Point(15, 149);
            chkGrip.Name = "chkGrip";
            chkGrip.Size = new System.Drawing.Size(91, 21);
            chkGrip.TabIndex = 13;
            chkGrip.Text = "Show grip";
            chkGrip.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(320, 153);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 17);
            label5.TabIndex = 14;
            label5.Text = "Title padding [px]:";
            // 
            // txtPaddingIcon
            // 
            txtPaddingIcon.Location = new System.Drawing.Point(514, 201);
            txtPaddingIcon.Name = "txtPaddingIcon";
            txtPaddingIcon.Size = new System.Drawing.Size(100, 24);
            txtPaddingIcon.TabIndex = 15;
            txtPaddingIcon.Text = "0";
            // 
            // chkScroll
            // 
            chkScroll.AutoSize = true;
            chkScroll.Checked = true;
            chkScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            chkScroll.Location = new System.Drawing.Point(15, 175);
            chkScroll.Name = "chkScroll";
            chkScroll.Size = new System.Drawing.Size(102, 21);
            chkScroll.TabIndex = 16;
            chkScroll.Text = "Scroll in/out";
            chkScroll.UseVisualStyleBackColor = true;
            // 
            // txtPaddingContent
            // 
            txtPaddingContent.Location = new System.Drawing.Point(514, 175);
            txtPaddingContent.Name = "txtPaddingContent";
            txtPaddingContent.Size = new System.Drawing.Size(100, 24);
            txtPaddingContent.TabIndex = 17;
            txtPaddingContent.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(320, 205);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(123, 17);
            label6.TabIndex = 18;
            label6.Text = "Icon padding [px]:";
            // 
            // txtPaddingTitle
            // 
            txtPaddingTitle.Location = new System.Drawing.Point(514, 149);
            txtPaddingTitle.Name = "txtPaddingTitle";
            txtPaddingTitle.Size = new System.Drawing.Size(100, 24);
            txtPaddingTitle.TabIndex = 19;
            txtPaddingTitle.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(320, 179);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(146, 17);
            label7.TabIndex = 20;
            label7.Text = "Content padding [px]:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem, settingsToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(141, 76);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            aboutToolStripMenuItem.Text = "About...";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            settingsToolStripMenuItem.Text = "Settings...";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(320, 127);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(158, 17);
            label8.TabIndex = 21;
            label8.Text = "AnimationDuration [ms]:";
            // 
            // txtAnimationDuration
            // 
            txtAnimationDuration.Location = new System.Drawing.Point(514, 123);
            txtAnimationDuration.Name = "txtAnimationDuration";
            txtAnimationDuration.Size = new System.Drawing.Size(100, 24);
            txtAnimationDuration.TabIndex = 22;
            txtAnimationDuration.Text = "1000";
            // 
            // chkIsRightToLeft
            // 
            chkIsRightToLeft.AutoSize = true;
            chkIsRightToLeft.Location = new System.Drawing.Point(15, 201);
            chkIsRightToLeft.Name = "chkIsRightToLeft";
            chkIsRightToLeft.Size = new System.Drawing.Size(292, 21);
            chkIsRightToLeft.TabIndex = 23;
            chkIsRightToLeft.Text = "Right to Left/ راست به چپ \\ מימין לשמאל";
            chkIsRightToLeft.UseVisualStyleBackColor = true;
            // 
            // btnMore
            // 
            btnMore.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnMore.Location = new System.Drawing.Point(911, 340);
            btnMore.Name = "btnMore";
            btnMore.Size = new System.Drawing.Size(153, 23);
            btnMore.TabIndex = 24;
            btnMore.Text = "Multiple Popups";
            btnMore.UseVisualStyleBackColor = true;
            btnMore.Click += btnMore_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new System.Drawing.Point(348, 17);
            lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new System.Drawing.Size(45, 17);
            lblColor.TabIndex = 25;
            lblColor.Text = "Color:";
            // 
            // lblColorValue
            // 
            lblColorValue.AutoSize = true;
            lblColorValue.BackColor = System.Drawing.Color.Black;
            lblColorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblColorValue.ForeColor = System.Drawing.Color.Transparent;
            lblColorValue.Location = new System.Drawing.Point(402, 17);
            lblColorValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblColorValue.Name = "lblColorValue";
            lblColorValue.Size = new System.Drawing.Size(26, 19);
            lblColorValue.TabIndex = 26;
            lblColorValue.Text = "    ";
            lblColorValue.Click += lblColorValue_Click;
            // 
            // lblTextColor
            // 
            lblTextColor.AutoSize = true;
            lblTextColor.BackColor = System.Drawing.Color.Black;
            lblTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTextColor.ForeColor = System.Drawing.Color.Transparent;
            lblTextColor.Location = new System.Drawing.Point(402, 46);
            lblTextColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTextColor.Name = "lblTextColor";
            lblTextColor.Size = new System.Drawing.Size(26, 19);
            lblTextColor.TabIndex = 28;
            lblTextColor.Text = "    ";
            lblTextColor.Click += lblTextColor_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(348, 46);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(45, 17);
            label10.TabIndex = 27;
            label10.Text = "Color:";
            // 
            // txtBorder
            // 
            txtBorder.Location = new System.Drawing.Point(207, 275);
            txtBorder.Name = "txtBorder";
            txtBorder.Size = new System.Drawing.Size(100, 24);
            txtBorder.TabIndex = 29;
            txtBorder.Text = "5";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 279);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(188, 17);
            label9.TabIndex = 30;
            label9.Text = "Border Size (zero or positive):";
            // 
            // txtHeaderHeight
            // 
            txtHeaderHeight.Location = new System.Drawing.Point(207, 303);
            txtHeaderHeight.Name = "txtHeaderHeight";
            txtHeaderHeight.Size = new System.Drawing.Size(100, 24);
            txtHeaderHeight.TabIndex = 31;
            txtHeaderHeight.Text = "10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(14, 307);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(94, 17);
            label11.TabIndex = 32;
            label11.Text = "Header Height";
            // 
            // gbSound
            // 
            gbSound.Controls.Add(btnOpemSoundFile);
            gbSound.Controls.Add(txtSoundPath);
            gbSound.Controls.Add(rbCustom);
            gbSound.Controls.Add(rbNotification);
            gbSound.Controls.Add(rbHand);
            gbSound.Controls.Add(rbQuestion);
            gbSound.Controls.Add(rbExclamation);
            gbSound.Controls.Add(rbBeep);
            gbSound.Controls.Add(rbAsterisk);
            gbSound.Location = new System.Drawing.Point(631, 101);
            gbSound.Name = "gbSound";
            gbSound.Size = new System.Drawing.Size(439, 125);
            gbSound.TabIndex = 33;
            gbSound.TabStop = false;
            gbSound.Text = "Use Sound on popup";
            // 
            // btnOpemSoundFile
            // 
            btnOpemSoundFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOpemSoundFile.Location = new System.Drawing.Point(401, 86);
            btnOpemSoundFile.Name = "btnOpemSoundFile";
            btnOpemSoundFile.Size = new System.Drawing.Size(32, 23);
            btnOpemSoundFile.TabIndex = 31;
            btnOpemSoundFile.Text = "..";
            btnOpemSoundFile.UseVisualStyleBackColor = true;
            btnOpemSoundFile.Click += btnOpemSoundFile_Click;
            // 
            // txtSoundPath
            // 
            txtSoundPath.Location = new System.Drawing.Point(89, 85);
            txtSoundPath.Name = "txtSoundPath";
            txtSoundPath.Size = new System.Drawing.Size(306, 24);
            txtSoundPath.TabIndex = 30;
            // 
            // rbCustom
            // 
            rbCustom.AutoSize = true;
            rbCustom.Location = new System.Drawing.Point(5, 86);
            rbCustom.Name = "rbCustom";
            rbCustom.Size = new System.Drawing.Size(77, 21);
            rbCustom.TabIndex = 7;
            rbCustom.Text = "Custom";
            rbCustom.UseVisualStyleBackColor = true;
            // 
            // rbNotification
            // 
            rbNotification.AutoSize = true;
            rbNotification.Checked = true;
            rbNotification.Location = new System.Drawing.Point(5, 22);
            rbNotification.Name = "rbNotification";
            rbNotification.Size = new System.Drawing.Size(96, 21);
            rbNotification.TabIndex = 6;
            rbNotification.TabStop = true;
            rbNotification.Text = "Notification";
            rbNotification.UseVisualStyleBackColor = true;
            // 
            // rbHand
            // 
            rbHand.AutoSize = true;
            rbHand.Location = new System.Drawing.Point(259, 27);
            rbHand.Name = "rbHand";
            rbHand.Size = new System.Drawing.Size(61, 21);
            rbHand.TabIndex = 5;
            rbHand.Text = "Hand";
            rbHand.UseVisualStyleBackColor = true;
            // 
            // rbQuestion
            // 
            rbQuestion.AutoSize = true;
            rbQuestion.Location = new System.Drawing.Point(113, 50);
            rbQuestion.Name = "rbQuestion";
            rbQuestion.Size = new System.Drawing.Size(83, 21);
            rbQuestion.TabIndex = 4;
            rbQuestion.Text = "Question";
            rbQuestion.UseVisualStyleBackColor = true;
            // 
            // rbExclamation
            // 
            rbExclamation.AutoSize = true;
            rbExclamation.Location = new System.Drawing.Point(113, 24);
            rbExclamation.Name = "rbExclamation";
            rbExclamation.Size = new System.Drawing.Size(103, 21);
            rbExclamation.TabIndex = 3;
            rbExclamation.Text = "Exclamation";
            rbExclamation.UseVisualStyleBackColor = true;
            // 
            // rbBeep
            // 
            rbBeep.AutoSize = true;
            rbBeep.Location = new System.Drawing.Point(6, 50);
            rbBeep.Name = "rbBeep";
            rbBeep.Size = new System.Drawing.Size(59, 21);
            rbBeep.TabIndex = 2;
            rbBeep.Text = "Beep";
            rbBeep.UseVisualStyleBackColor = true;
            // 
            // rbAsterisk
            // 
            rbAsterisk.AutoSize = true;
            rbAsterisk.Location = new System.Drawing.Point(259, 50);
            rbAsterisk.Name = "rbAsterisk";
            rbAsterisk.Size = new System.Drawing.Size(75, 21);
            rbAsterisk.TabIndex = 0;
            rbAsterisk.Text = "Asterisk";
            rbAsterisk.UseVisualStyleBackColor = true;
            // 
            // chkbSound
            // 
            chkbSound.AutoSize = true;
            chkbSound.Location = new System.Drawing.Point(631, 74);
            chkbSound.Name = "chkbSound";
            chkbSound.Size = new System.Drawing.Size(120, 21);
            chkbSound.TabIndex = 1;
            chkbSound.Text = "Enable Sounds";
            chkbSound.UseVisualStyleBackColor = true;
            // 
            // chkbAutoHeight
            // 
            chkbAutoHeight.AutoSize = true;
            chkbAutoHeight.Checked = true;
            chkbAutoHeight.CheckState = System.Windows.Forms.CheckState.Checked;
            chkbAutoHeight.Location = new System.Drawing.Point(15, 228);
            chkbAutoHeight.Name = "chkbAutoHeight";
            chkbAutoHeight.Size = new System.Drawing.Size(136, 21);
            chkbAutoHeight.TabIndex = 34;
            chkbAutoHeight.Text = "Auto size (height)";
            chkbAutoHeight.UseVisualStyleBackColor = true;
            // 
            // chkbPopupRelative
            // 
            chkbPopupRelative.AutoSize = true;
            chkbPopupRelative.Checked = true;
            chkbPopupRelative.CheckState = System.Windows.Forms.CheckState.Checked;
            chkbPopupRelative.Location = new System.Drawing.Point(320, 231);
            chkbPopupRelative.Name = "chkbPopupRelative";
            chkbPopupRelative.Size = new System.Drawing.Size(180, 21);
            chkbPopupRelative.TabIndex = 35;
            chkbPopupRelative.Text = "Popup relative to Screen";
            chkbPopupRelative.UseVisualStyleBackColor = true;
            // 
            // gbLocation
            // 
            gbLocation.Controls.Add(rbTopLeft);
            gbLocation.Controls.Add(rbBottomRight);
            gbLocation.Controls.Add(rbTopRight);
            gbLocation.Controls.Add(rbBottomLeft);
            gbLocation.Location = new System.Drawing.Point(514, 231);
            gbLocation.Name = "gbLocation";
            gbLocation.Size = new System.Drawing.Size(100, 71);
            gbLocation.TabIndex = 34;
            gbLocation.TabStop = false;
            gbLocation.Text = "Location";
            // 
            // rbTopLeft
            // 
            rbTopLeft.AutoSize = true;
            rbTopLeft.Location = new System.Drawing.Point(6, 23);
            rbTopLeft.Name = "rbTopLeft";
            rbTopLeft.Size = new System.Drawing.Size(17, 16);
            rbTopLeft.TabIndex = 6;
            rbTopLeft.UseVisualStyleBackColor = true;
            // 
            // rbBottomRight
            // 
            rbBottomRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            rbBottomRight.AutoSize = true;
            rbBottomRight.Checked = true;
            rbBottomRight.Location = new System.Drawing.Point(77, 49);
            rbBottomRight.Name = "rbBottomRight";
            rbBottomRight.Size = new System.Drawing.Size(17, 16);
            rbBottomRight.TabIndex = 4;
            rbBottomRight.TabStop = true;
            rbBottomRight.UseVisualStyleBackColor = true;
            // 
            // rbTopRight
            // 
            rbTopRight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rbTopRight.AutoSize = true;
            rbTopRight.Location = new System.Drawing.Point(77, 23);
            rbTopRight.Name = "rbTopRight";
            rbTopRight.Size = new System.Drawing.Size(17, 16);
            rbTopRight.TabIndex = 3;
            rbTopRight.UseVisualStyleBackColor = true;
            // 
            // rbBottomLeft
            // 
            rbBottomLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            rbBottomLeft.AutoSize = true;
            rbBottomLeft.Location = new System.Drawing.Point(6, 49);
            rbBottomLeft.Name = "rbBottomLeft";
            rbBottomLeft.Size = new System.Drawing.Size(17, 16);
            rbBottomLeft.TabIndex = 2;
            rbBottomLeft.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1078, 371);
            Controls.Add(gbLocation);
            Controls.Add(chkbPopupRelative);
            Controls.Add(chkbAutoHeight);
            Controls.Add(gbSound);
            Controls.Add(chkbSound);
            Controls.Add(txtHeaderHeight);
            Controls.Add(label11);
            Controls.Add(txtBorder);
            Controls.Add(label9);
            Controls.Add(lblTextColor);
            Controls.Add(label10);
            Controls.Add(lblColorValue);
            Controls.Add(lblColor);
            Controls.Add(btnMore);
            Controls.Add(chkIsRightToLeft);
            Controls.Add(txtPaddingTitle);
            Controls.Add(label7);
            Controls.Add(txtAnimationDuration);
            Controls.Add(label8);
            Controls.Add(chkScroll);
            Controls.Add(txtPaddingContent);
            Controls.Add(txtPaddingIcon);
            Controls.Add(label6);
            Controls.Add(chkGrip);
            Controls.Add(label5);
            Controls.Add(txtDelay);
            Controls.Add(label3);
            Controls.Add(txtInterval);
            Controls.Add(label4);
            Controls.Add(chkMenu);
            Controls.Add(chkClose);
            Controls.Add(chkIcon);
            Controls.Add(txtText);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShow);
            Controls.Add(btnExit);
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "NotificationWindow Demo";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            gbSound.ResumeLayout(false);
            gbSound.PerformLayout();
            gbLocation.ResumeLayout(false);
            gbLocation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.GroupBox gbSound;
        private System.Windows.Forms.RadioButton rbAsterisk;
        private System.Windows.Forms.CheckBox chkbSound;
        private System.Windows.Forms.RadioButton rbBeep;
        private System.Windows.Forms.RadioButton rbNotification;
        private System.Windows.Forms.RadioButton rbHand;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.RadioButton rbExclamation;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.TextBox txtSoundPath;
        private System.Windows.Forms.Button btnOpemSoundFile;
        private System.Windows.Forms.CheckBox chkbAutoHeight;
        private System.Windows.Forms.CheckBox chkbPopupRelative;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.RadioButton rbTopLeft;
        private System.Windows.Forms.RadioButton rbBottomRight;
        private System.Windows.Forms.RadioButton rbTopRight;
        private System.Windows.Forms.RadioButton rbBottomLeft;
    }
}

