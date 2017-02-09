using BI_Tool_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BI_Tool_GUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string clickedNode;
        MenuItem miTestGroupNewTest = new MenuItem("New Test");
        MenuItem miTestGroupRenameGroup = new MenuItem("Rename Test Group");
        MenuItem miTestGroupDeleteGroup = new MenuItem("Delete Test Group");
        MenuItem miTestMapColumns = new MenuItem("Map Columns");
        MenuItem miTestDeleteTest = new MenuItem("Delete Test");
        MenuItem miNewTGNewGroup = new MenuItem("New Test Group");

        ContextMenu mnuTestGroup = new ContextMenu();
        ContextMenu mnuTest = new ContextMenu();
        ContextMenu mnuNewTG = new ContextMenu();

        #region Init
        public Form1()
        {
            InitializeComponent();
            InitializeTreeViewSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void InitializeTreeViewSelection()
        {
            InitializeTestGroupMenuSelection();
            InitializeTestMenuSelection();
            InitializePanelMenuSelection();
        }

        private void InitializePanelMenuSelection()
        {
            mnuNewTG.MenuItems.Add(miNewTGNewGroup);
            miNewTGNewGroup.Click += new EventHandler(miNewTGNewGroup_Click);
        }

        private void InitializeTestGroupMenuSelection()
        {
            mnuTestGroup.MenuItems.Add(miTestGroupNewTest);
            miTestGroupNewTest.Click += new EventHandler(miTestGroupNewTest_Click);

            mnuTestGroup.MenuItems.Add(miTestGroupRenameGroup);
            miTestGroupRenameGroup.Click += new EventHandler(miTestGroupRenameGroup_Click);

            mnuTestGroup.MenuItems.Add(miTestGroupDeleteGroup);
            miTestGroupDeleteGroup.Click += new EventHandler(miTestGroupDeleteGroup_Click);
        }

        private void InitializeTestMenuSelection()
        {
            mnuTest.MenuItems.Add(miTestMapColumns);
            miTestMapColumns.Click += new EventHandler(miTestMapColumns_Click);

            mnuTest.MenuItems.Add(miTestDeleteTest);
            miTestDeleteTest.Click += new EventHandler(miTestDeleteTest_Click);
        }

        
        #endregion

        #region GUI
        private void AddSampleProjectGui()
        {
            lblProjectTitle.Text = "Compass DB Testing";

            TreeNode table1 = new TreeNode("sql.Negative -> gbq.Negative");
            TreeNode table2 = new TreeNode("sql.NegativeID -> gbq.NegativeID");
            TreeNode table3 = new TreeNode("sql.NegativeRowCount -> gbq.NegativeRowCount");
            TreeNode table4 = new TreeNode("sql.NegativeSchema -> gbq.NegativeSchema");
            TreeNode table5 = new TreeNode("sql.Positive -> gbq.Positive");
            TreeNode[] array = new TreeNode[] { table1, table2, table3, table4, table5 };

            TreeNode treeNode = new TreeNode("Full Regression", array);
            tvProject.Nodes.Add(treeNode);

            array = new TreeNode[] { (TreeNode)table1.Clone(), (TreeNode)table2.Clone(), (TreeNode)table3.Clone()};
            treeNode = new TreeNode("UPI Regression", array);
            tvProject.Nodes.Add(treeNode);

            array = new TreeNode[] { (TreeNode)table4.Clone(), (TreeNode)table5.Clone() };
            treeNode = new TreeNode("UCH Regression", array);
            tvProject.Nodes.Add(treeNode);

            array = new TreeNode[] { (TreeNode)table1.Clone() };
            treeNode = new TreeNode("Bug Verification", array);
            tvProject.Nodes.Add(treeNode);
        }

        private void OpenProjectFile()
        {
            var openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size);
            Console.WriteLine(result);
        }
        #endregion

        #region Controls
        private void newProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Enter Project Name", "New Project");
            lblProjectTitle.Text = promptValue;
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProjectFile();
            AddSampleProjectGui();
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mnuNewTG.Show(tvProject, e.Location);
            }
        }

        private void tvProject_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clickedNode = e.Node.Name;

                if (e.Node.Level == 0)
                {
                    mnuTestGroup.Show(tvProject, e.Location);
                } else
                {
                    mnuTest.Show(tvProject, e.Location);
                }
            }
        }

        private void miTestGroupNewTest_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = clickedNode;
            frm.ShowDialog(this);
            clickedNode = "";
        }

        private void miTestGroupRenameGroup_Click(object sender, EventArgs e)
        {
            
        }

        private void miTestGroupDeleteGroup_Click(object sender, EventArgs e)
        {
            
        }

        private void miTestDeleteTest_Click(object sender, EventArgs e)
        {
            
        }

        private void miTestMapColumns_Click(object sender, EventArgs e)
        {
            
        }

        private void miNewTGNewGroup_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Enter Test Group Name", "New Test Group");
            
            TreeNode treeNode = new TreeNode(promptValue);
            tvProject.Nodes.Add(treeNode);
        }
        #endregion


    }
}
