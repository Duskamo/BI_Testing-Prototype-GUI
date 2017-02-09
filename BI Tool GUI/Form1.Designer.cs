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
            this.mappingSaveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.mappingSaveBtn);
            this.panel2.Controls.Add(this.dataGridMapping);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(260, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 332);
            this.panel2.TabIndex = 1;
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
    }
}

