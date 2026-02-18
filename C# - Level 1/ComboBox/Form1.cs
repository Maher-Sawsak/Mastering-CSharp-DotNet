using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            //i didn't use the index cuz maybe will changee the order of comboBox for sorting.
            switch (comboBox1.SelectedItem.ToString().ToLower())
            {

                case "book":
                    pbObjectsPicture.Image = Properties.Resources.Book;
                    break; 
                case "boy":
                    pbObjectsPicture.Image = Properties.Resources.Boy;
                    break;
                case "girl":
                    pbObjectsPicture.Image = Properties.Resources.Girl;
                    break;
                case "pen":
                    pbObjectsPicture.Image = Properties.Resources.Pen;
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("-Large");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }
    }
}
