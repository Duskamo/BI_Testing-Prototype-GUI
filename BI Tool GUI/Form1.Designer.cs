using System;
using System.Windows.Forms;

namespace BI_Tool_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvProject = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tctlCompare = new System.Windows.Forms.TabControl();
            this.srcPage = new System.Windows.Forms.TabPage();
            this.txtSrcPwd = new System.Windows.Forms.TextBox();
            this.lblSrcPwd = new System.Windows.Forms.Label();
            this.txtSrcUser = new System.Windows.Forms.TextBox();
            this.lblSrcUser = new System.Windows.Forms.Label();
            this.chkSrcWinAuth = new System.Windows.Forms.CheckBox();
            this.txtSrcServer = new System.Windows.Forms.TextBox();
            this.lblSrcServer = new System.Windows.Forms.Label();
            this.rbtnSrcGoogle = new System.Windows.Forms.RadioButton();
            this.rbtnSrcNetezza = new System.Windows.Forms.RadioButton();
            this.rbtnSrcOracle = new System.Windows.Forms.RadioButton();
            this.rbtnSrcSql = new System.Windows.Forms.RadioButton();
            this.trgPage = new System.Windows.Forms.TabPage();
            this.mappingSaveBtn = new System.Windows.Forms.Button();
            this.dataGridMapping = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.mbutCompare = new MetroFramework.Controls.MetroButton();
            this.mbutExport = new MetroFramework.Controls.MetroButton();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mlProjectTitle = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblSrcDB = new System.Windows.Forms.Label();
            this.cboSrcDB = new System.Windows.Forms.ComboBox();
            this.btnSrcRfs = new System.Windows.Forms.Button();
            this.lblSrcTable = new System.Windows.Forms.Label();
            this.cboSrcTable = new System.Windows.Forms.ComboBox();
            this.btnSrcRfst = new System.Windows.Forms.Button();
            this.lblSrcTableSelect = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSrcUse = new System.Windows.Forms.Button();
            this.btnTrgUse = new System.Windows.Forms.Button();
            this.btnTrgRfst = new System.Windows.Forms.Button();
            this.btnTrgRfs = new System.Windows.Forms.Button();
            this.cboTrgTableSelect = new System.Windows.Forms.ComboBox();
            this.cboTrgTable = new System.Windows.Forms.ComboBox();
            this.cboTrgDB = new System.Windows.Forms.ComboBox();
            this.lblTrgTableSelect = new System.Windows.Forms.Label();
            this.lblTrgTable = new System.Windows.Forms.Label();
            this.lblTrgDB = new System.Windows.Forms.Label();
            this.txtTrgPwd = new System.Windows.Forms.TextBox();
            this.lblTrgPwd = new System.Windows.Forms.Label();
            this.txtTrgUser = new System.Windows.Forms.TextBox();
            this.lblTrgUser = new System.Windows.Forms.Label();
            this.chkTrgWinAuth = new System.Windows.Forms.CheckBox();
            this.txtTrgServer = new System.Windows.Forms.TextBox();
            this.lblTrgServer = new System.Windows.Forms.Label();
            this.rbtnTrgGoogle = new System.Windows.Forms.RadioButton();
            this.rbtnTrgNetezza = new System.Windows.Forms.RadioButton();
            this.rbtnTrgOracle = new System.Windows.Forms.RadioButton();
            this.rbtnTrgSql = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tctlCompare.SuspendLayout();
            this.srcPage.SuspendLayout();
            this.trgPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.tvProject);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 553);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // tvProject
            // 
            this.tvProject.BackColor = System.Drawing.Color.Red;
            this.tvProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvProject.Location = new System.Drawing.Point(23, 16);
            this.tvProject.Name = "tvProject";
            this.tvProject.Size = new System.Drawing.Size(214, 316);
            this.tvProject.TabIndex = 0;
            this.tvProject.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvProject_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.tctlCompare);
            this.panel2.Controls.Add(this.mappingSaveBtn);
            this.panel2.Controls.Add(this.dataGridMapping);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(260, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 332);
            this.panel2.TabIndex = 1;
            // 
            // tctlCompare
            // 
            this.tctlCompare.Controls.Add(this.srcPage);
            this.tctlCompare.Controls.Add(this.trgPage);
            this.tctlCompare.ItemSize = new System.Drawing.Size(160, 18);
            this.tctlCompare.Location = new System.Drawing.Point(171, 27);
            this.tctlCompare.Name = "tctlCompare";
            this.tctlCompare.SelectedIndex = 0;
            this.tctlCompare.Size = new System.Drawing.Size(449, 288);
            this.tctlCompare.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctlCompare.TabIndex = 14;
            // 
            // srcPage
            // 
            this.srcPage.Controls.Add(this.btnSrcUse);
            this.srcPage.Controls.Add(this.btnSrcRfst);
            this.srcPage.Controls.Add(this.btnSrcRfs);
            this.srcPage.Controls.Add(this.comboBox1);
            this.srcPage.Controls.Add(this.cboSrcTable);
            this.srcPage.Controls.Add(this.cboSrcDB);
            this.srcPage.Controls.Add(this.lblSrcTableSelect);
            this.srcPage.Controls.Add(this.lblSrcTable);
            this.srcPage.Controls.Add(this.lblSrcDB);
            this.srcPage.Controls.Add(this.txtSrcPwd);
            this.srcPage.Controls.Add(this.lblSrcPwd);
            this.srcPage.Controls.Add(this.txtSrcUser);
            this.srcPage.Controls.Add(this.lblSrcUser);
            this.srcPage.Controls.Add(this.chkSrcWinAuth);
            this.srcPage.Controls.Add(this.txtSrcServer);
            this.srcPage.Controls.Add(this.lblSrcServer);
            this.srcPage.Controls.Add(this.rbtnSrcGoogle);
            this.srcPage.Controls.Add(this.rbtnSrcNetezza);
            this.srcPage.Controls.Add(this.rbtnSrcOracle);
            this.srcPage.Controls.Add(this.rbtnSrcSql);
            this.srcPage.Location = new System.Drawing.Point(4, 22);
            this.srcPage.Name = "srcPage";
            this.srcPage.Padding = new System.Windows.Forms.Padding(3);
            this.srcPage.Size = new System.Drawing.Size(441, 262);
            this.srcPage.TabIndex = 0;
            this.srcPage.Text = "Source";
            this.srcPage.UseVisualStyleBackColor = true;
            // 
            // txtSrcPwd
            // 
            this.txtSrcPwd.Location = new System.Drawing.Point(96, 118);
            this.txtSrcPwd.Name = "txtSrcPwd";
            this.txtSrcPwd.Size = new System.Drawing.Size(266, 20);
            this.txtSrcPwd.TabIndex = 11;
            // 
            // lblSrcPwd
            // 
            this.lblSrcPwd.AutoSize = true;
            this.lblSrcPwd.Location = new System.Drawing.Point(24, 122);
            this.lblSrcPwd.Name = "lblSrcPwd";
            this.lblSrcPwd.Size = new System.Drawing.Size(53, 13);
            this.lblSrcPwd.TabIndex = 10;
            this.lblSrcPwd.Text = "Password";
            // 
            // txtSrcUser
            // 
            this.txtSrcUser.Location = new System.Drawing.Point(96, 92);
            this.txtSrcUser.Name = "txtSrcUser";
            this.txtSrcUser.Size = new System.Drawing.Size(266, 20);
            this.txtSrcUser.TabIndex = 9;
            // 
            // lblSrcUser
            // 
            this.lblSrcUser.AutoSize = true;
            this.lblSrcUser.Location = new System.Drawing.Point(24, 95);
            this.lblSrcUser.Name = "lblSrcUser";
            this.lblSrcUser.Size = new System.Drawing.Size(29, 13);
            this.lblSrcUser.TabIndex = 8;
            this.lblSrcUser.Text = "User";
            // 
            // chkSrcWinAuth
            // 
            this.chkSrcWinAuth.AutoSize = true;
            this.chkSrcWinAuth.Location = new System.Drawing.Point(96, 69);
            this.chkSrcWinAuth.Name = "chkSrcWinAuth";
            this.chkSrcWinAuth.Size = new System.Drawing.Size(141, 17);
            this.chkSrcWinAuth.TabIndex = 7;
            this.chkSrcWinAuth.Text = "Windows Authentication";
            this.chkSrcWinAuth.UseVisualStyleBackColor = true;
            // 
            // txtSrcServer
            // 
            this.txtSrcServer.Location = new System.Drawing.Point(96, 43);
            this.txtSrcServer.Name = "txtSrcServer";
            this.txtSrcServer.Size = new System.Drawing.Size(266, 20);
            this.txtSrcServer.TabIndex = 6;
            // 
            // lblSrcServer
            // 
            this.lblSrcServer.AutoSize = true;
            this.lblSrcServer.Location = new System.Drawing.Point(24, 46);
            this.lblSrcServer.Name = "lblSrcServer";
            this.lblSrcServer.Size = new System.Drawing.Size(38, 13);
            this.lblSrcServer.TabIndex = 5;
            this.lblSrcServer.Text = "Server";
            // 
            // rbtnSrcGoogle
            // 
            this.rbtnSrcGoogle.Location = new System.Drawing.Point(291, 3);
            this.rbtnSrcGoogle.Name = "rbtnSrcGoogle";
            this.rbtnSrcGoogle.Size = new System.Drawing.Size(48, 17);
            this.rbtnSrcGoogle.TabIndex = 1;
            this.rbtnSrcGoogle.TabStop = true;
            this.rbtnSrcGoogle.Text = "GBQ";
            this.rbtnSrcGoogle.UseVisualStyleBackColor = true;
            // 
            // rbtnSrcNetezza
            // 
            this.rbtnSrcNetezza.Location = new System.Drawing.Point(221, 3);
            this.rbtnSrcNetezza.Name = "rbtnSrcNetezza";
            this.rbtnSrcNetezza.Size = new System.Drawing.Size(64, 17);
            this.rbtnSrcNetezza.TabIndex = 2;
            this.rbtnSrcNetezza.TabStop = true;
            this.rbtnSrcNetezza.Text = "Netezza";
            this.rbtnSrcNetezza.UseVisualStyleBackColor = true;
            // 
            // rbtnSrcOracle
            // 
            this.rbtnSrcOracle.Location = new System.Drawing.Point(159, 3);
            this.rbtnSrcOracle.Name = "rbtnSrcOracle";
            this.rbtnSrcOracle.Size = new System.Drawing.Size(56, 17);
            this.rbtnSrcOracle.TabIndex = 3;
            this.rbtnSrcOracle.TabStop = true;
            this.rbtnSrcOracle.Text = "Oracle";
            this.rbtnSrcOracle.UseVisualStyleBackColor = true;
            // 
            // rbtnSrcSql
            // 
            this.rbtnSrcSql.Location = new System.Drawing.Point(73, 3);
            this.rbtnSrcSql.Name = "rbtnSrcSql";
            this.rbtnSrcSql.Size = new System.Drawing.Size(80, 17);
            this.rbtnSrcSql.TabIndex = 4;
            this.rbtnSrcSql.TabStop = true;
            this.rbtnSrcSql.Text = "SQL Sever";
            this.rbtnSrcSql.UseVisualStyleBackColor = true;
            // 
            // trgPage
            // 
            this.trgPage.Controls.Add(this.btnTrgUse);
            this.trgPage.Controls.Add(this.btnTrgRfst);
            this.trgPage.Controls.Add(this.btnTrgRfs);
            this.trgPage.Controls.Add(this.cboTrgTableSelect);
            this.trgPage.Controls.Add(this.cboTrgTable);
            this.trgPage.Controls.Add(this.cboTrgDB);
            this.trgPage.Controls.Add(this.lblTrgTableSelect);
            this.trgPage.Controls.Add(this.lblTrgTable);
            this.trgPage.Controls.Add(this.lblTrgDB);
            this.trgPage.Controls.Add(this.txtTrgPwd);
            this.trgPage.Controls.Add(this.lblTrgPwd);
            this.trgPage.Controls.Add(this.txtTrgUser);
            this.trgPage.Controls.Add(this.lblTrgUser);
            this.trgPage.Controls.Add(this.chkTrgWinAuth);
            this.trgPage.Controls.Add(this.txtTrgServer);
            this.trgPage.Controls.Add(this.lblTrgServer);
            this.trgPage.Controls.Add(this.rbtnTrgGoogle);
            this.trgPage.Controls.Add(this.rbtnTrgNetezza);
            this.trgPage.Controls.Add(this.rbtnTrgOracle);
            this.trgPage.Controls.Add(this.rbtnTrgSql);
            this.trgPage.Location = new System.Drawing.Point(4, 22);
            this.trgPage.Name = "trgPage";
            this.trgPage.Padding = new System.Windows.Forms.Padding(3);
            this.trgPage.Size = new System.Drawing.Size(441, 262);
            this.trgPage.TabIndex = 1;
            this.trgPage.Text = "Target";
            this.trgPage.UseVisualStyleBackColor = true;
            // 
            // mappingSaveBtn
            // 
            this.mappingSaveBtn.Location = new System.Drawing.Point(702, 0);
            this.mappingSaveBtn.Name = "mappingSaveBtn";
            this.mappingSaveBtn.Size = new System.Drawing.Size(72, 24);
            this.mappingSaveBtn.TabIndex = 13;
            this.mappingSaveBtn.Text = "Save";
            this.mappingSaveBtn.UseVisualStyleBackColor = true;
            this.mappingSaveBtn.Click += new System.EventHandler(this.mappingSaveBtn_Click);
            // 
            // dataGridMapping
            // 
            this.dataGridMapping.AllowUserToAddRows = false;
            this.dataGridMapping.AllowUserToDeleteRows = false;
            this.dataGridMapping.AllowUserToResizeRows = false;
            this.dataGridMapping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.SourceColumn,
            this.TargetColumn,
            this.Key});
            this.dataGridMapping.Location = new System.Drawing.Point(0, 0);
            this.dataGridMapping.Name = "dataGridMapping";
            this.dataGridMapping.RowHeadersWidth = 20;
            this.dataGridMapping.Size = new System.Drawing.Size(774, 332);
            this.dataGridMapping.TabIndex = 12;
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected.Width = 55;
            // 
            // SourceColumn
            // 
            this.SourceColumn.HeaderText = "SourceColumn";
            this.SourceColumn.Name = "SourceColumn";
            // 
            // TargetColumn
            // 
            this.TargetColumn.HeaderText = "TargetColumn";
            this.TargetColumn.Name = "TargetColumn";
            this.TargetColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TargetColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Key
            // 
            this.Key.HeaderText = "Is Key?";
            this.Key.Name = "Key";
            this.Key.Width = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 107);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.dgvOutput);
            this.panel3.Location = new System.Drawing.Point(260, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 186);
            this.panel3.TabIndex = 2;
            // 
            // dgvOutput
            // 
            this.dgvOutput.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutput.Location = new System.Drawing.Point(0, 0);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.Size = new System.Drawing.Size(774, 186);
            this.dgvOutput.TabIndex = 0;
            // 
            // mbutCompare
            // 
            this.mbutCompare.Location = new System.Drawing.Point(280, 374);
            this.mbutCompare.Name = "mbutCompare";
            this.mbutCompare.Size = new System.Drawing.Size(75, 23);
            this.mbutCompare.TabIndex = 8;
            this.mbutCompare.Text = "Compare";
            // 
            // mbutExport
            // 
            this.mbutExport.Location = new System.Drawing.Point(377, 374);
            this.mbutExport.Name = "mbutExport";
            this.mbutExport.Size = new System.Drawing.Size(75, 23);
            this.mbutExport.TabIndex = 9;
            this.mbutExport.Text = "Export";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.lblProjectTitle);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Controls.Add(this.mlProjectTitle);
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(956, 31);
            this.panel4.TabIndex = 10;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Location = new System.Drawing.Point(277, 10);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(0, 13);
            this.lblProjectTitle.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(956, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem1,
            this.openProjectToolStripMenuItem,
            this.closeProjectToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 27);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // newProjectToolStripMenuItem1
            // 
            this.newProjectToolStripMenuItem1.Name = "newProjectToolStripMenuItem1";
            this.newProjectToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.newProjectToolStripMenuItem1.Text = "New Project";
            this.newProjectToolStripMenuItem1.Click += new System.EventHandler(this.newProjectToolStripMenuItem1_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem1
            // 
            this.closeProjectToolStripMenuItem1.Name = "closeProjectToolStripMenuItem1";
            this.closeProjectToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.closeProjectToolStripMenuItem1.Text = "Close Project";
            // 
            // mlProjectTitle
            // 
            this.mlProjectTitle.AutoSize = true;
            this.mlProjectTitle.Location = new System.Drawing.Point(280, 4);
            this.mlProjectTitle.Name = "mlProjectTitle";
            this.mlProjectTitle.Size = new System.Drawing.Size(0, 0);
            this.mlProjectTitle.TabIndex = 1;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblSrcDB
            // 
            this.lblSrcDB.AutoSize = true;
            this.lblSrcDB.Location = new System.Drawing.Point(24, 149);
            this.lblSrcDB.Name = "lblSrcDB";
            this.lblSrcDB.Size = new System.Drawing.Size(53, 13);
            this.lblSrcDB.TabIndex = 12;
            this.lblSrcDB.Text = "Database";
            // 
            // cboSrcDB
            // 
            this.cboSrcDB.DropDownWidth = 196;
            this.cboSrcDB.FormattingEnabled = true;
            this.cboSrcDB.Location = new System.Drawing.Point(96, 149);
            this.cboSrcDB.Name = "cboSrcDB";
            this.cboSrcDB.Size = new System.Drawing.Size(185, 21);
            this.cboSrcDB.TabIndex = 13;
            // 
            // btnSrcRfs
            // 
            this.btnSrcRfs.Location = new System.Drawing.Point(287, 149);
            this.btnSrcRfs.Name = "btnSrcRfs";
            this.btnSrcRfs.Size = new System.Drawing.Size(75, 23);
            this.btnSrcRfs.TabIndex = 14;
            this.btnSrcRfs.Text = "Connect";
            this.btnSrcRfs.UseVisualStyleBackColor = true;
            // 
            // lblSrcTable
            // 
            this.lblSrcTable.AutoSize = true;
            this.lblSrcTable.Location = new System.Drawing.Point(24, 176);
            this.lblSrcTable.Name = "lblSrcTable";
            this.lblSrcTable.Size = new System.Drawing.Size(62, 13);
            this.lblSrcTable.TabIndex = 12;
            this.lblSrcTable.Text = "Table/View";
            // 
            // cboSrcTable
            // 
            this.cboSrcTable.DropDownWidth = 196;
            this.cboSrcTable.FormattingEnabled = true;
            this.cboSrcTable.Location = new System.Drawing.Point(96, 176);
            this.cboSrcTable.Name = "cboSrcTable";
            this.cboSrcTable.Size = new System.Drawing.Size(185, 21);
            this.cboSrcTable.TabIndex = 13;
            // 
            // btnSrcRfst
            // 
            this.btnSrcRfst.Location = new System.Drawing.Point(287, 176);
            this.btnSrcRfst.Name = "btnSrcRfst";
            this.btnSrcRfst.Size = new System.Drawing.Size(75, 23);
            this.btnSrcRfst.TabIndex = 14;
            this.btnSrcRfst.Text = "Select";
            this.btnSrcRfst.UseVisualStyleBackColor = true;
            // 
            // lblSrcTableSelect
            // 
            this.lblSrcTableSelect.AutoSize = true;
            this.lblSrcTableSelect.Location = new System.Drawing.Point(24, 203);
            this.lblSrcTableSelect.Name = "lblSrcTableSelect";
            this.lblSrcTableSelect.Size = new System.Drawing.Size(34, 13);
            this.lblSrcTableSelect.TabIndex = 12;
            this.lblSrcTableSelect.Text = "Table";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 196;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // btnSrcUse
            // 
            this.btnSrcUse.Location = new System.Drawing.Point(287, 203);
            this.btnSrcUse.Name = "btnSrcUse";
            this.btnSrcUse.Size = new System.Drawing.Size(75, 23);
            this.btnSrcUse.TabIndex = 14;
            this.btnSrcUse.Text = "Use";
            this.btnSrcUse.UseVisualStyleBackColor = true;
            // 
            // btnTrgUse
            // 
            this.btnTrgUse.Location = new System.Drawing.Point(279, 193);
            this.btnTrgUse.Name = "btnTrgUse";
            this.btnTrgUse.Size = new System.Drawing.Size(75, 23);
            this.btnTrgUse.TabIndex = 48;
            this.btnTrgUse.Text = "Use";
            this.btnTrgUse.UseVisualStyleBackColor = true;
            // 
            // btnTrgRfst
            // 
            this.btnTrgRfst.Location = new System.Drawing.Point(279, 166);
            this.btnTrgRfst.Name = "btnTrgRfst";
            this.btnTrgRfst.Size = new System.Drawing.Size(75, 23);
            this.btnTrgRfst.TabIndex = 49;
            this.btnTrgRfst.Text = "Select";
            this.btnTrgRfst.UseVisualStyleBackColor = true;
            // 
            // btnTrgRfs
            // 
            this.btnTrgRfs.Location = new System.Drawing.Point(279, 139);
            this.btnTrgRfs.Name = "btnTrgRfs";
            this.btnTrgRfs.Size = new System.Drawing.Size(75, 23);
            this.btnTrgRfs.TabIndex = 50;
            this.btnTrgRfs.Text = "Connect";
            this.btnTrgRfs.UseVisualStyleBackColor = true;
            // 
            // cboTrgTableSelect
            // 
            this.cboTrgTableSelect.DropDownWidth = 196;
            this.cboTrgTableSelect.FormattingEnabled = true;
            this.cboTrgTableSelect.Location = new System.Drawing.Point(88, 193);
            this.cboTrgTableSelect.Name = "cboTrgTableSelect";
            this.cboTrgTableSelect.Size = new System.Drawing.Size(185, 21);
            this.cboTrgTableSelect.TabIndex = 45;
            // 
            // cboTrgTable
            // 
            this.cboTrgTable.DropDownWidth = 196;
            this.cboTrgTable.FormattingEnabled = true;
            this.cboTrgTable.Location = new System.Drawing.Point(88, 166);
            this.cboTrgTable.Name = "cboTrgTable";
            this.cboTrgTable.Size = new System.Drawing.Size(185, 21);
            this.cboTrgTable.TabIndex = 46;
            // 
            // cboTrgDB
            // 
            this.cboTrgDB.DropDownWidth = 196;
            this.cboTrgDB.FormattingEnabled = true;
            this.cboTrgDB.Location = new System.Drawing.Point(88, 139);
            this.cboTrgDB.Name = "cboTrgDB";
            this.cboTrgDB.Size = new System.Drawing.Size(185, 21);
            this.cboTrgDB.TabIndex = 47;
            // 
            // lblTrgTableSelect
            // 
            this.lblTrgTableSelect.AutoSize = true;
            this.lblTrgTableSelect.Location = new System.Drawing.Point(16, 193);
            this.lblTrgTableSelect.Name = "lblTrgTableSelect";
            this.lblTrgTableSelect.Size = new System.Drawing.Size(34, 13);
            this.lblTrgTableSelect.TabIndex = 42;
            this.lblTrgTableSelect.Text = "Table";
            // 
            // lblTrgTable
            // 
            this.lblTrgTable.AutoSize = true;
            this.lblTrgTable.Location = new System.Drawing.Point(16, 166);
            this.lblTrgTable.Name = "lblTrgTable";
            this.lblTrgTable.Size = new System.Drawing.Size(62, 13);
            this.lblTrgTable.TabIndex = 43;
            this.lblTrgTable.Text = "Table/View";
            // 
            // lblTrgDB
            // 
            this.lblTrgDB.AutoSize = true;
            this.lblTrgDB.Location = new System.Drawing.Point(16, 139);
            this.lblTrgDB.Name = "lblTrgDB";
            this.lblTrgDB.Size = new System.Drawing.Size(53, 13);
            this.lblTrgDB.TabIndex = 44;
            this.lblTrgDB.Text = "Database";
            // 
            // txtTrgPwd
            // 
            this.txtTrgPwd.Location = new System.Drawing.Point(88, 108);
            this.txtTrgPwd.Name = "txtTrgPwd";
            this.txtTrgPwd.Size = new System.Drawing.Size(266, 20);
            this.txtTrgPwd.TabIndex = 41;
            // 
            // lblTrgPwd
            // 
            this.lblTrgPwd.AutoSize = true;
            this.lblTrgPwd.Location = new System.Drawing.Point(16, 112);
            this.lblTrgPwd.Name = "lblTrgPwd";
            this.lblTrgPwd.Size = new System.Drawing.Size(53, 13);
            this.lblTrgPwd.TabIndex = 40;
            this.lblTrgPwd.Text = "Password";
            // 
            // txtTrgUser
            // 
            this.txtTrgUser.Location = new System.Drawing.Point(88, 82);
            this.txtTrgUser.Name = "txtTrgUser";
            this.txtTrgUser.Size = new System.Drawing.Size(266, 20);
            this.txtTrgUser.TabIndex = 39;
            // 
            // lblTrgUser
            // 
            this.lblTrgUser.AutoSize = true;
            this.lblTrgUser.Location = new System.Drawing.Point(16, 85);
            this.lblTrgUser.Name = "lblTrgUser";
            this.lblTrgUser.Size = new System.Drawing.Size(29, 13);
            this.lblTrgUser.TabIndex = 38;
            this.lblTrgUser.Text = "User";
            // 
            // chkTrgWinAuth
            // 
            this.chkTrgWinAuth.AutoSize = true;
            this.chkTrgWinAuth.Location = new System.Drawing.Point(88, 59);
            this.chkTrgWinAuth.Name = "chkTrgWinAuth";
            this.chkTrgWinAuth.Size = new System.Drawing.Size(141, 17);
            this.chkTrgWinAuth.TabIndex = 37;
            this.chkTrgWinAuth.Text = "Windows Authentication";
            this.chkTrgWinAuth.UseVisualStyleBackColor = true;
            // 
            // txtTrgServer
            // 
            this.txtTrgServer.Location = new System.Drawing.Point(88, 33);
            this.txtTrgServer.Name = "txtTrgServer";
            this.txtTrgServer.Size = new System.Drawing.Size(266, 20);
            this.txtTrgServer.TabIndex = 36;
            // 
            // lblTrgServer
            // 
            this.lblTrgServer.AutoSize = true;
            this.lblTrgServer.Location = new System.Drawing.Point(16, 36);
            this.lblTrgServer.Name = "lblTrgServer";
            this.lblTrgServer.Size = new System.Drawing.Size(38, 13);
            this.lblTrgServer.TabIndex = 35;
            this.lblTrgServer.Text = "Server";
            // 
            // rbtnTrgGoogle
            // 
            this.rbtnTrgGoogle.Location = new System.Drawing.Point(275, 3);
            this.rbtnTrgGoogle.Name = "rbtnTrgGoogle";
            this.rbtnTrgGoogle.Size = new System.Drawing.Size(48, 17);
            this.rbtnTrgGoogle.TabIndex = 33;
            this.rbtnTrgGoogle.TabStop = true;
            this.rbtnTrgGoogle.Text = "GBQ";
            this.rbtnTrgGoogle.UseVisualStyleBackColor = true;
            // 
            // rbtnTrgNetezza
            // 
            this.rbtnTrgNetezza.Location = new System.Drawing.Point(205, 3);
            this.rbtnTrgNetezza.Name = "rbtnTrgNetezza";
            this.rbtnTrgNetezza.Size = new System.Drawing.Size(64, 17);
            this.rbtnTrgNetezza.TabIndex = 32;
            this.rbtnTrgNetezza.TabStop = true;
            this.rbtnTrgNetezza.Text = "Netezza";
            this.rbtnTrgNetezza.UseVisualStyleBackColor = true;
            // 
            // rbtnTrgOracle
            // 
            this.rbtnTrgOracle.Location = new System.Drawing.Point(143, 3);
            this.rbtnTrgOracle.Name = "rbtnTrgOracle";
            this.rbtnTrgOracle.Size = new System.Drawing.Size(56, 17);
            this.rbtnTrgOracle.TabIndex = 34;
            this.rbtnTrgOracle.TabStop = true;
            this.rbtnTrgOracle.Text = "Oracle";
            this.rbtnTrgOracle.UseVisualStyleBackColor = true;
            // 
            // rbtnTrgSql
            // 
            this.rbtnTrgSql.Location = new System.Drawing.Point(57, 3);
            this.rbtnTrgSql.Name = "rbtnTrgSql";
            this.rbtnTrgSql.Size = new System.Drawing.Size(80, 17);
            this.rbtnTrgSql.TabIndex = 31;
            this.rbtnTrgSql.TabStop = true;
            this.rbtnTrgSql.Text = "SQL Sever";
            this.rbtnTrgSql.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 590);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.mbutExport);
            this.Controls.Add(this.mbutCompare);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tctlCompare.ResumeLayout(false);
            this.srcPage.ResumeLayout(false);
            this.srcPage.PerformLayout();
            this.trgPage.ResumeLayout(false);
            this.trgPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton mbutCompare;
        private MetroFramework.Controls.MetroButton mbutExport;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.TreeView tvProject;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel mlProjectTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem1;
        private System.Windows.Forms.Label lblProjectTitle;
        private DataGridView dataGridMapping;
        private DataGridViewCheckBoxColumn Selected;
        private DataGridViewTextBoxColumn SourceColumn;
        private DataGridViewComboBoxColumn TargetColumn;
        private DataGridViewCheckBoxColumn Key;
        private Button mappingSaveBtn;
        private TabControl tctlCompare;
        private TabPage srcPage;
        private TabPage trgPage;
        private RadioButton rbtnSrcGoogle;
        private RadioButton rbtnSrcNetezza;
        private RadioButton rbtnSrcOracle;
        private RadioButton rbtnSrcSql;
        private TextBox txtSrcPwd;
        private Label lblSrcPwd;
        private TextBox txtSrcUser;
        private Label lblSrcUser;
        private CheckBox chkSrcWinAuth;
        private TextBox txtSrcServer;
        private Label lblSrcServer;
        private Button btnSrcUse;
        private Button btnSrcRfst;
        private Button btnSrcRfs;
        private ComboBox comboBox1;
        private ComboBox cboSrcTable;
        private ComboBox cboSrcDB;
        private Label lblSrcTableSelect;
        private Label lblSrcTable;
        private Label lblSrcDB;
        private Button btnTrgUse;
        private Button btnTrgRfst;
        private Button btnTrgRfs;
        private ComboBox cboTrgTableSelect;
        private ComboBox cboTrgTable;
        private ComboBox cboTrgDB;
        private Label lblTrgTableSelect;
        private Label lblTrgTable;
        private Label lblTrgDB;
        private TextBox txtTrgPwd;
        private Label lblTrgPwd;
        private TextBox txtTrgUser;
        private Label lblTrgUser;
        private CheckBox chkTrgWinAuth;
        private TextBox txtTrgServer;
        private Label lblTrgServer;
        private RadioButton rbtnTrgGoogle;
        private RadioButton rbtnTrgNetezza;
        private RadioButton rbtnTrgOracle;
        private RadioButton rbtnTrgSql;
    }

}

