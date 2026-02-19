using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView_and_ImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void CheckTreeViewNode(TreeNode Node , Boolean IsChecked) {


            foreach (TreeNode item in Node.Nodes) {

                item.Checked = IsChecked;

                if (item.Nodes.Count > 0) {
                    CheckTreeViewNode(item, IsChecked);
                }
            }
        
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);

        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show($"You Expand {e.Node.Text} Nodes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
