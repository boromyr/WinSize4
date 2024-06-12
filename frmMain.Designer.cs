namespace WinSize4
{
    partial class frmMain
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            tbExe = new TextBox();
            butOK = new Button();
            butApply = new Button();
            butExit = new Button();
            butRemove = new Button();
            label3 = new Label();
            tbLeft = new TextBox();
            label4 = new Label();
            tbTop = new TextBox();
            label5 = new Label();
            tbWidth = new TextBox();
            label6 = new Label();
            tbHeight = new TextBox();
            cbCustomWidth = new CheckBox();
            cbCustomHeight = new CheckBox();
            cbFullScreen = new CheckBox();
            butCancel = new Button();
            butEditScreens = new Button();
            cbSearchExe = new CheckBox();
            groupBox1 = new GroupBox();
            tbHotKeyCharacter = new TextBox();
            cbHotKeyRight = new ComboBox();
            cbHotKeyLeft = new ComboBox();
            notifyIcon1 = new NotifyIcon(components);
            label7 = new Label();
            tbName = new TextBox();
            cbResetIfNewScreen = new CheckBox();
            groupBox2 = new GroupBox();
            butDuplicate = new Button();
            groupBox4 = new GroupBox();
            radioStartsWithInclude = new RadioButton();
            radioContainsInclude = new RadioButton();
            radioFullInclude = new RadioButton();
            tbTitleInclude = new TextBox();
            cbSearchTitleInclude = new CheckBox();
            groupBox3 = new GroupBox();
            radioStartsWithExclude = new RadioButton();
            radioContainsExclude = new RadioButton();
            radioFullExclude = new RadioButton();
            tbTitleExclude = new TextBox();
            cbSearchTitleExclude = new CheckBox();
            tbSavedWindowIndex = new Label();
            tbWindowClass = new TextBox();
            label8 = new Label();
            cbWindowClass = new CheckBox();
            cbIgnoreChildWindows = new CheckBox();
            butResetMoved = new Button();
            toolTip1 = new ToolTip(components);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            cbShowAllWindows = new CheckBox();
            cbRunAtLogin = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtVersion = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 402);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 4;
            label2.Text = "Executable";
            // 
            // tbExe
            // 
            tbExe.Location = new Point(216, 389);
            tbExe.Margin = new Padding(5, 4, 5, 4);
            tbExe.Name = "tbExe";
            tbExe.Size = new Size(391, 29);
            tbExe.TabIndex = 3;
            // 
            // butOK
            // 
            butOK.Location = new Point(694, 847);
            butOK.Margin = new Padding(5, 4, 5, 4);
            butOK.Name = "butOK";
            butOK.Size = new Size(159, 38);
            butOK.TabIndex = 5;
            butOK.Text = "Apply and Hide";
            butOK.UseVisualStyleBackColor = true;
            butOK.Click += butOK_Click;
            // 
            // butApply
            // 
            butApply.Location = new Point(984, 847);
            butApply.Margin = new Padding(5, 4, 5, 4);
            butApply.Name = "butApply";
            butApply.Size = new Size(113, 38);
            butApply.TabIndex = 6;
            butApply.Text = "Apply";
            butApply.UseVisualStyleBackColor = true;
            butApply.Click += butApply_Click;
            // 
            // butExit
            // 
            butExit.Location = new Point(1104, 847);
            butExit.Margin = new Padding(5, 4, 5, 4);
            butExit.Name = "butExit";
            butExit.Size = new Size(113, 38);
            butExit.TabIndex = 7;
            butExit.Text = "Exit";
            butExit.UseVisualStyleBackColor = true;
            butExit.Click += butExit_Click;
            // 
            // butRemove
            // 
            butRemove.Location = new Point(15, 599);
            butRemove.Margin = new Padding(5, 4, 5, 4);
            butRemove.Name = "butRemove";
            butRemove.Size = new Size(175, 38);
            butRemove.TabIndex = 8;
            butRemove.Text = "Remove";
            butRemove.UseVisualStyleBackColor = true;
            butRemove.Click += butRemove_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 437);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 10;
            label3.Text = "Left";
            // 
            // tbLeft
            // 
            tbLeft.Location = new Point(216, 431);
            tbLeft.Margin = new Padding(5, 4, 5, 4);
            tbLeft.Name = "tbLeft";
            tbLeft.Size = new Size(167, 29);
            tbLeft.TabIndex = 9;
            tbLeft.TextChanged += tbLeft_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 479);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 12;
            label4.Text = "Top";
            // 
            // tbTop
            // 
            tbTop.Location = new Point(216, 473);
            tbTop.Margin = new Padding(5, 4, 5, 4);
            tbTop.Name = "tbTop";
            tbTop.Size = new Size(167, 29);
            tbTop.TabIndex = 11;
            tbTop.TextChanged += tbTop_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 528);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 14;
            label5.Text = "Width";
            // 
            // tbWidth
            // 
            tbWidth.Location = new Point(216, 515);
            tbWidth.Margin = new Padding(5, 4, 5, 4);
            tbWidth.Name = "tbWidth";
            tbWidth.Size = new Size(167, 29);
            tbWidth.TabIndex = 13;
            tbWidth.TextChanged += tbWidth_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 570);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 16;
            label6.Text = "Height";
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(216, 557);
            tbHeight.Margin = new Padding(5, 4, 5, 4);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(167, 29);
            tbHeight.TabIndex = 15;
            tbHeight.TextChanged += tbHeight_TextChanged;
            // 
            // cbCustomWidth
            // 
            cbCustomWidth.AutoSize = true;
            cbCustomWidth.Location = new Point(424, 518);
            cbCustomWidth.Margin = new Padding(5, 4, 5, 4);
            cbCustomWidth.Name = "cbCustomWidth";
            cbCustomWidth.Size = new Size(88, 25);
            cbCustomWidth.TabIndex = 17;
            cbCustomWidth.Text = "Custom";
            cbCustomWidth.UseVisualStyleBackColor = true;
            cbCustomWidth.CheckedChanged += cbCustomWidth_CheckedChanged;
            cbCustomWidth.MouseHover += checkBox_MouseHover;
            // 
            // cbCustomHeight
            // 
            cbCustomHeight.AutoSize = true;
            cbCustomHeight.Location = new Point(424, 560);
            cbCustomHeight.Margin = new Padding(5, 4, 5, 4);
            cbCustomHeight.Name = "cbCustomHeight";
            cbCustomHeight.Size = new Size(88, 25);
            cbCustomHeight.TabIndex = 18;
            cbCustomHeight.Text = "Custom";
            cbCustomHeight.UseVisualStyleBackColor = true;
            cbCustomHeight.CheckedChanged += cbCustomHeight_CheckedChanged;
            cbCustomHeight.MouseHover += checkBox_MouseHover;
            // 
            // cbFullScreen
            // 
            cbFullScreen.AutoSize = true;
            cbFullScreen.Location = new Point(424, 476);
            cbFullScreen.Margin = new Padding(5, 4, 5, 4);
            cbFullScreen.Name = "cbFullScreen";
            cbFullScreen.Size = new Size(109, 25);
            cbFullScreen.TabIndex = 19;
            cbFullScreen.Text = "Full screen";
            cbFullScreen.UseVisualStyleBackColor = true;
            cbFullScreen.CheckedChanged += cbFullScreen_CheckedChanged;
            cbFullScreen.MouseHover += checkBox_MouseHover;
            // 
            // butCancel
            // 
            butCancel.DialogResult = DialogResult.Cancel;
            butCancel.Location = new Point(861, 847);
            butCancel.Margin = new Padding(5, 4, 5, 4);
            butCancel.Name = "butCancel";
            butCancel.Size = new Size(113, 38);
            butCancel.TabIndex = 20;
            butCancel.Text = "Hide";
            butCancel.UseVisualStyleBackColor = true;
            butCancel.Click += butCancel_Click;
            // 
            // butEditScreens
            // 
            butEditScreens.Location = new Point(1043, 749);
            butEditScreens.Margin = new Padding(5, 4, 5, 4);
            butEditScreens.Name = "butEditScreens";
            butEditScreens.Size = new Size(175, 38);
            butEditScreens.TabIndex = 33;
            butEditScreens.Text = "Edit screens";
            butEditScreens.UseVisualStyleBackColor = true;
            butEditScreens.Click += butEditScreens_Click;
            // 
            // cbSearchExe
            // 
            cbSearchExe.AutoSize = true;
            cbSearchExe.Location = new Point(168, 403);
            cbSearchExe.Margin = new Padding(5, 4, 5, 4);
            cbSearchExe.Name = "cbSearchExe";
            cbSearchExe.Size = new Size(18, 17);
            cbSearchExe.TabIndex = 36;
            cbSearchExe.UseVisualStyleBackColor = true;
            cbSearchExe.CheckedChanged += cbSearchExe_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbHotKeyCharacter);
            groupBox1.Controls.Add(cbHotKeyRight);
            groupBox1.Controls.Add(cbHotKeyLeft);
            groupBox1.Location = new Point(595, 718);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(383, 85);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hotkey";
            // 
            // tbHotKeyCharacter
            // 
            tbHotKeyCharacter.CharacterCasing = CharacterCasing.Upper;
            tbHotKeyCharacter.Location = new Point(297, 31);
            tbHotKeyCharacter.Margin = new Padding(5, 4, 5, 4);
            tbHotKeyCharacter.MaxLength = 1;
            tbHotKeyCharacter.Name = "tbHotKeyCharacter";
            tbHotKeyCharacter.Size = new Size(67, 29);
            tbHotKeyCharacter.TabIndex = 2;
            tbHotKeyCharacter.TextAlign = HorizontalAlignment.Center;
            tbHotKeyCharacter.TextChanged += tbHotKeyCharacter_TextChanged;
            // 
            // cbHotKeyRight
            // 
            cbHotKeyRight.FormattingEnabled = true;
            cbHotKeyRight.Items.AddRange(new object[] { "None" });
            cbHotKeyRight.Location = new Point(154, 31);
            cbHotKeyRight.Margin = new Padding(5, 4, 5, 4);
            cbHotKeyRight.Name = "cbHotKeyRight";
            cbHotKeyRight.Size = new Size(131, 29);
            cbHotKeyRight.TabIndex = 1;
            cbHotKeyRight.SelectedIndexChanged += cbHotKeyRight_SelectedIndexChanged;
            // 
            // cbHotKeyLeft
            // 
            cbHotKeyLeft.FormattingEnabled = true;
            cbHotKeyLeft.Items.AddRange(new object[] { "Alt", "Ctrl", "Shift" });
            cbHotKeyLeft.Location = new Point(12, 31);
            cbHotKeyLeft.Margin = new Padding(5, 4, 5, 4);
            cbHotKeyLeft.Name = "cbHotKeyLeft";
            cbHotKeyLeft.Size = new Size(131, 29);
            cbHotKeyLeft.TabIndex = 0;
            cbHotKeyLeft.SelectedIndexChanged += cbHotKeyLeft_SelectedIndexChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "WinSize4";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 42);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 40;
            label7.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(211, 31);
            tbName.Margin = new Padding(5, 4, 5, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(391, 29);
            tbName.TabIndex = 39;
            // 
            // cbResetIfNewScreen
            // 
            cbResetIfNewScreen.AutoSize = true;
            cbResetIfNewScreen.Location = new Point(617, 683);
            cbResetIfNewScreen.Margin = new Padding(5, 4, 5, 4);
            cbResetIfNewScreen.Name = "cbResetIfNewScreen";
            cbResetIfNewScreen.Size = new Size(313, 25);
            cbResetIfNewScreen.TabIndex = 41;
            cbResetIfNewScreen.Text = "Reset moved if new screen is detected";
            cbResetIfNewScreen.UseVisualStyleBackColor = true;
            cbResetIfNewScreen.CheckedChanged += cbResetIfNewScreen_CheckedChanged;
            cbResetIfNewScreen.MouseHover += checkBox_MouseHover;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(butDuplicate);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(tbSavedWindowIndex);
            groupBox2.Controls.Add(tbWindowClass);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbWindowClass);
            groupBox2.Controls.Add(cbIgnoreChildWindows);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbExe);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(butRemove);
            groupBox2.Controls.Add(tbLeft);
            groupBox2.Controls.Add(cbSearchExe);
            groupBox2.Controls.Add(tbTop);
            groupBox2.Controls.Add(tbWidth);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbHeight);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbCustomWidth);
            groupBox2.Controls.Add(cbFullScreen);
            groupBox2.Controls.Add(cbCustomHeight);
            groupBox2.Location = new Point(595, 20);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(622, 655);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected window";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // butDuplicate
            // 
            butDuplicate.Location = new Point(211, 599);
            butDuplicate.Margin = new Padding(5, 4, 5, 4);
            butDuplicate.Name = "butDuplicate";
            butDuplicate.Size = new Size(175, 38);
            butDuplicate.TabIndex = 57;
            butDuplicate.Text = "Duplicate";
            butDuplicate.UseVisualStyleBackColor = true;
            butDuplicate.Click += butDuplicate_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioStartsWithInclude);
            groupBox4.Controls.Add(radioContainsInclude);
            groupBox4.Controls.Add(radioFullInclude);
            groupBox4.Controls.Add(tbTitleInclude);
            groupBox4.Controls.Add(cbSearchTitleInclude);
            groupBox4.Location = new Point(13, 118);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(600, 129);
            groupBox4.TabIndex = 56;
            groupBox4.TabStop = false;
            groupBox4.Text = "Window Title Include";
            // 
            // radioStartsWithInclude
            // 
            radioStartsWithInclude.AutoSize = true;
            radioStartsWithInclude.Location = new Point(208, 84);
            radioStartsWithInclude.Margin = new Padding(5, 4, 5, 4);
            radioStartsWithInclude.Name = "radioStartsWithInclude";
            radioStartsWithInclude.Size = new Size(107, 25);
            radioStartsWithInclude.TabIndex = 49;
            radioStartsWithInclude.Text = "Starts with";
            radioStartsWithInclude.UseVisualStyleBackColor = true;
            // 
            // radioContainsInclude
            // 
            radioContainsInclude.AutoSize = true;
            radioContainsInclude.Location = new Point(105, 84);
            radioContainsInclude.Margin = new Padding(5, 4, 5, 4);
            radioContainsInclude.Name = "radioContainsInclude";
            radioContainsInclude.Size = new Size(94, 25);
            radioContainsInclude.TabIndex = 48;
            radioContainsInclude.Text = "Contains";
            radioContainsInclude.UseVisualStyleBackColor = true;
            // 
            // radioFullInclude
            // 
            radioFullInclude.AutoSize = true;
            radioFullInclude.Location = new Point(39, 84);
            radioFullInclude.Margin = new Padding(5, 4, 5, 4);
            radioFullInclude.Name = "radioFullInclude";
            radioFullInclude.Size = new Size(56, 25);
            radioFullInclude.TabIndex = 47;
            radioFullInclude.Text = "Full";
            radioFullInclude.UseVisualStyleBackColor = true;
            // 
            // tbTitleInclude
            // 
            tbTitleInclude.Location = new Point(39, 43);
            tbTitleInclude.Margin = new Padding(5, 4, 5, 4);
            tbTitleInclude.Name = "tbTitleInclude";
            tbTitleInclude.Size = new Size(556, 29);
            tbTitleInclude.TabIndex = 44;
            tbTitleInclude.TextChanged += tbTitleInclude_TextChanged;
            // 
            // cbSearchTitleInclude
            // 
            cbSearchTitleInclude.AutoSize = true;
            cbSearchTitleInclude.Location = new Point(9, 49);
            cbSearchTitleInclude.Margin = new Padding(5, 4, 5, 4);
            cbSearchTitleInclude.Name = "cbSearchTitleInclude";
            cbSearchTitleInclude.Size = new Size(18, 17);
            cbSearchTitleInclude.TabIndex = 46;
            cbSearchTitleInclude.UseVisualStyleBackColor = true;
            cbSearchTitleInclude.CheckedChanged += cbSearchTitleInclude_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioStartsWithExclude);
            groupBox3.Controls.Add(radioContainsExclude);
            groupBox3.Controls.Add(radioFullExclude);
            groupBox3.Controls.Add(tbTitleExclude);
            groupBox3.Controls.Add(cbSearchTitleExclude);
            groupBox3.Location = new Point(13, 255);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(600, 126);
            groupBox3.TabIndex = 55;
            groupBox3.TabStop = false;
            groupBox3.Text = "Window Title Exclude";
            // 
            // radioStartsWithExclude
            // 
            radioStartsWithExclude.AutoSize = true;
            radioStartsWithExclude.Location = new Point(208, 78);
            radioStartsWithExclude.Margin = new Padding(5, 4, 5, 4);
            radioStartsWithExclude.Name = "radioStartsWithExclude";
            radioStartsWithExclude.Size = new Size(107, 25);
            radioStartsWithExclude.TabIndex = 60;
            radioStartsWithExclude.Text = "Starts with";
            radioStartsWithExclude.UseVisualStyleBackColor = true;
            // 
            // radioContainsExclude
            // 
            radioContainsExclude.AutoSize = true;
            radioContainsExclude.Location = new Point(105, 78);
            radioContainsExclude.Margin = new Padding(5, 4, 5, 4);
            radioContainsExclude.Name = "radioContainsExclude";
            radioContainsExclude.Size = new Size(94, 25);
            radioContainsExclude.TabIndex = 59;
            radioContainsExclude.Text = "Contains";
            radioContainsExclude.UseVisualStyleBackColor = true;
            // 
            // radioFullExclude
            // 
            radioFullExclude.AutoSize = true;
            radioFullExclude.Location = new Point(39, 78);
            radioFullExclude.Margin = new Padding(5, 4, 5, 4);
            radioFullExclude.Name = "radioFullExclude";
            radioFullExclude.Size = new Size(56, 25);
            radioFullExclude.TabIndex = 58;
            radioFullExclude.Text = "Full";
            radioFullExclude.UseVisualStyleBackColor = true;
            // 
            // tbTitleExclude
            // 
            tbTitleExclude.Location = new Point(39, 38);
            tbTitleExclude.Margin = new Padding(5, 4, 5, 4);
            tbTitleExclude.Name = "tbTitleExclude";
            tbTitleExclude.Size = new Size(556, 29);
            tbTitleExclude.TabIndex = 55;
            tbTitleExclude.TextChanged += tbTitleExclude_TextChanged;
            // 
            // cbSearchTitleExclude
            // 
            cbSearchTitleExclude.AutoSize = true;
            cbSearchTitleExclude.Location = new Point(9, 43);
            cbSearchTitleExclude.Margin = new Padding(5, 4, 5, 4);
            cbSearchTitleExclude.Name = "cbSearchTitleExclude";
            cbSearchTitleExclude.Size = new Size(18, 17);
            cbSearchTitleExclude.TabIndex = 57;
            cbSearchTitleExclude.UseVisualStyleBackColor = true;
            cbSearchTitleExclude.CheckedChanged += cbSearchTitleExclude_CheckedChanged;
            // 
            // tbSavedWindowIndex
            // 
            tbSavedWindowIndex.AutoSize = true;
            tbSavedWindowIndex.Location = new Point(154, 42);
            tbSavedWindowIndex.Margin = new Padding(5, 0, 5, 0);
            tbSavedWindowIndex.Name = "tbSavedWindowIndex";
            tbSavedWindowIndex.Size = new Size(19, 21);
            tbSavedWindowIndex.TabIndex = 48;
            tbSavedWindowIndex.Text = "0";
            // 
            // tbWindowClass
            // 
            tbWindowClass.Location = new Point(211, 71);
            tbWindowClass.Margin = new Padding(5, 4, 5, 4);
            tbWindowClass.Name = "tbWindowClass";
            tbWindowClass.ReadOnly = true;
            tbWindowClass.Size = new Size(391, 29);
            tbWindowClass.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 83);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 21);
            label8.TabIndex = 46;
            label8.Text = "Window Class";
            // 
            // cbWindowClass
            // 
            cbWindowClass.AutoSize = true;
            cbWindowClass.Location = new Point(165, 84);
            cbWindowClass.Margin = new Padding(5, 4, 5, 4);
            cbWindowClass.Name = "cbWindowClass";
            cbWindowClass.Size = new Size(18, 17);
            cbWindowClass.TabIndex = 47;
            cbWindowClass.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreChildWindows
            // 
            cbIgnoreChildWindows.AutoSize = true;
            cbIgnoreChildWindows.Location = new Point(424, 606);
            cbIgnoreChildWindows.Margin = new Padding(5, 4, 5, 4);
            cbIgnoreChildWindows.Name = "cbIgnoreChildWindows";
            cbIgnoreChildWindows.Size = new Size(192, 25);
            cbIgnoreChildWindows.TabIndex = 44;
            cbIgnoreChildWindows.Text = "Ignore Child Windows";
            cbIgnoreChildWindows.UseVisualStyleBackColor = true;
            // 
            // butResetMoved
            // 
            butResetMoved.Location = new Point(1043, 683);
            butResetMoved.Margin = new Padding(5, 4, 5, 4);
            butResetMoved.Name = "butResetMoved";
            butResetMoved.Size = new Size(175, 38);
            butResetMoved.TabIndex = 43;
            butResetMoved.Text = "Reset moved";
            butResetMoved.UseVisualStyleBackColor = true;
            butResetMoved.Click += butResetMoved_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(18, 20);
            listView1.Margin = new Padding(5, 4, 5, 4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(554, 829);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 44;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.KeyDown += listView1_KeyDown;
            listView1.MouseClick += listView1_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 340;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Width";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Height";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Primary";
            columnHeader4.Width = 70;
            // 
            // cbShowAllWindows
            // 
            cbShowAllWindows.AutoSize = true;
            cbShowAllWindows.Location = new Point(17, 858);
            cbShowAllWindows.Margin = new Padding(5, 4, 5, 4);
            cbShowAllWindows.Name = "cbShowAllWindows";
            cbShowAllWindows.Size = new Size(206, 25);
            cbShowAllWindows.TabIndex = 45;
            cbShowAllWindows.Text = "Show all saved windows";
            cbShowAllWindows.UseVisualStyleBackColor = true;
            cbShowAllWindows.CheckedChanged += cbShowAllWindows_CheckedChanged;
            // 
            // cbRunAtLogin
            // 
            cbRunAtLogin.AutoSize = true;
            cbRunAtLogin.Location = new Point(603, 812);
            cbRunAtLogin.Margin = new Padding(5, 4, 5, 4);
            cbRunAtLogin.Name = "cbRunAtLogin";
            cbRunAtLogin.Size = new Size(119, 25);
            cbRunAtLogin.TabIndex = 46;
            cbRunAtLogin.Text = "Run at login";
            cbRunAtLogin.UseVisualStyleBackColor = true;
            cbRunAtLogin.CheckedChanged += cbRunAtLogin_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtVersion
            // 
            txtVersion.BorderStyle = BorderStyle.None;
            txtVersion.ForeColor = Color.Black;
            txtVersion.Location = new Point(445, 858);
            txtVersion.Margin = new Padding(4);
            txtVersion.Name = "txtVersion";
            txtVersion.ReadOnly = true;
            txtVersion.Size = new Size(129, 22);
            txtVersion.TabIndex = 47;
            txtVersion.TextAlign = HorizontalAlignment.Right;
            // 
            // frmMain
            // 
            AcceptButton = butOK;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = butCancel;
            ClientSize = new Size(1352, 945);
            Controls.Add(txtVersion);
            Controls.Add(cbRunAtLogin);
            Controls.Add(cbShowAllWindows);
            Controls.Add(listView1);
            Controls.Add(butResetMoved);
            Controls.Add(groupBox2);
            Controls.Add(cbResetIfNewScreen);
            Controls.Add(groupBox1);
            Controls.Add(butEditScreens);
            Controls.Add(butCancel);
            Controls.Add(butExit);
            Controls.Add(butApply);
            Controls.Add(butOK);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(273, 16);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.Manual;
            Text = "WinSize4";
            FormClosing += frmMain_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private TextBox tbExe;
        private Button butOK;
        private Button butApply;
        private Button butExit;
        private Button butRemove;
        private Label label3;
        private Label label4;
        private TextBox tbLeft;
        private TextBox tbTop;
        private Label label5;
        private TextBox tbWidth;
        private Label label6;
        private TextBox tbHeight;
        private CheckBox cbCustomWidth;
        private CheckBox cbCustomHeight;
        private CheckBox cbFullScreen;
        private Button butCancel;
        private Button butEditScreens;
        private CheckBox cbSearchExe;
        private GroupBox groupBox1;
        private ComboBox cbHotKeyLeft;
        private TextBox tbHotKeyCharacter;
        private ComboBox cbHotKeyRight;
        private NotifyIcon notifyIcon1;
        private Label label7;
        private TextBox tbName;
        private CheckBox cbResetIfNewScreen;
        private GroupBox groupBox2;
        private Button butResetMoved;
        private ToolTip toolTip1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private CheckBox cbShowAllWindows;
        private CheckBox cbIgnoreChildWindows;
        private CheckBox cbRunAtLogin;
        private TextBox tbWindowClass;
        private Label label8;
        private CheckBox cbWindowClass;
        private Label tbSavedWindowIndex;
        private GroupBox groupBox4;
        private RadioButton radioStartsWithInclude;
        private RadioButton radioContainsInclude;
        private RadioButton radioFullInclude;
        private TextBox tbTitleInclude;
        private CheckBox cbSearchTitleInclude;
        private GroupBox groupBox3;
        private RadioButton radioStartsWithExclude;
        private RadioButton radioContainsExclude;
        private RadioButton radioFullExclude;
        private TextBox tbTitleExclude;
        private CheckBox cbSearchTitleExclude;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtVersion;
        private Button butDuplicate;
    }
}

