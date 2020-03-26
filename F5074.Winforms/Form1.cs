using F5074.Winforms.MyForm.D_Common;
using F5074.Winforms.MyForm.DBConnect;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace F5074.Winforms
{
    public partial class Form1 : Form
    {
        private TreeNode[] treeNodeArray = { new TreeNode("MyCefSharp01"), new TreeNode("Form1"), new TreeNode("UserControl1") };

        private TabPage myTabPage;

        public Form1()
        {
            InitializeComponent();
            this.treeView1.Nodes.AddRange(treeNodeArray);
            //this.tabControl1.Controls.Add(new TabPage("Main"));
            this.treeView1.DoubleClick += new EventHandler(this.treeView1_DoubleClick);
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                switch (this.treeView1.SelectedNode.Text)
                {
                    case "MyCefSharp01":

                        myTabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                        myTabPage.Controls.Add(new MyTreeNode01() { Dock = DockStyle.Fill });
                        tabControl1.TabPages.Add(myTabPage);
                        this.tabControl1.SelectedTab = myTabPage;
                        this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
                        break;
                    case "Form1":

                        myTabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                        myTabPage.Controls.Add(new Form1() { Dock = DockStyle.Fill });
                        tabControl1.TabPages.Add(myTabPage);
                        this.tabControl1.SelectedTab = myTabPage;
                        this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
                        break;
                    case "UserControl1":

                        myTabPage = new TabPage() { Name = this.treeView1.SelectedNode.Text, Text = this.treeView1.SelectedNode.Text };
                        myTabPage.Controls.Add(new UserControl1() { Dock = DockStyle.Fill });
                        tabControl1.TabPages.Add(myTabPage);
                        this.tabControl1.SelectedTab = myTabPage;
                        this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
                        break;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddTabPage_1()
        {
            TabPage tabPage = new TabPage();
            tabPage.Location = new Point(4, 22);
            tabPage.Name = this.treeView1.SelectedNode.Text;
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(592, 424);
            tabPage.TabIndex = 0;
            tabPage.Text = this.treeView1.SelectedNode.Text;
            tabPage.UseVisualStyleBackColor = true;

            this.tabControl1.Controls.Add(tabPage);
        }

        //private void AddTabPage_2()
        //{
        //    FormTab1 formTab1 = new FormTab1();
        //    formTab1.TopLevel = false;
        //    formTab1.TopMost = true;
        //    formTab1.Dock = DockStyle.Fill;

        //    TabPage tabPage = new TabPage("TabPage");
        //    formTab1.Parent = tabPage;
        //    tabPage.Controls.Add(formTab1);

        //    this.tabControl1.Controls.Add(tabPage);

        //    formTab1.Show();
        //}
    }
}
