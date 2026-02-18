using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ckslbTasks.Items.Add(txtb1.Text);
        }

        private void txtb1_TextChanged(object sender, EventArgs e)
        {
            lblDisplaytxt.Visible = false;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            ckslbTasks.Items.RemoveAt(0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ckslbTasks.CheckedItems.Count; i++)
            {
                MessageBox.Show(ckslbTasks.CheckedItems[i].ToString(), "Checked Item");
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ckslbTasks.Items.Count; i++) {

                MessageBox.Show(ckslbTasks.Items[i].ToString());
            
            }
            /*or we can use foreach also.
            foreach (var item in ckslbTasks.Items) {
                MessageBox.Show(item.ToString());
            }
            */
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ckslbTasks.Items.Count; i++) {
                ckslbTasks.SetItemChecked(i, true);
            
            }
        }
    }
}
