using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                return;
            }
            //Here in the constructor will go to colum index 0 meaning Colum ID
            //and list viewitem will create like a row for data then add it to the list view.
            ListViewItem item = new ListViewItem(txtId.Text.Trim());
            //here subitem like set this value in next Colum
            item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(item);

            if (rbMale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;

            txtId.Clear();
            txtName.Clear();

            txtId.Focus();
        }

        private void rbDeteail_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0) {
                listView1.Items.Remove(listView1.Items[0]);
            }
        }

        private void btnFillRandomly_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i <= 10; i++) {
                ListViewItem item = new ListViewItem(i.ToString());
            
                item.SubItems.Add("Person" + i.ToString());

                if (i % 2 == 0)
                {
                    item.ImageIndex = 0;
                }
                else {
                    item.ImageIndex = 1;
                }


                listView1.Items.Add(item);
                

                item.Clone();

            }
        
        
        
        
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //first way
            //MessageBox.Show(listView1.SelectedItems[0].Text);

            //second way to show Id. 
            //here we can not store SelectedItems in item cuz contain a collection of items like array we need to choice the index
            ListViewItem item = listView1.SelectedItems[0];

            
            string ID = item.Text;
            string Name = item.SubItems[1].Text;

            MessageBox.Show($"Name : {Name} \n ID  : {ID}");
        }
    }

}
