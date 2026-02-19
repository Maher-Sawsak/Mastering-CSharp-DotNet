using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; //To prevent the user from clicking it again 
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;


            for (int i = 1; i <= 100; i++) {



                if (progressBar1.Value < progressBar1.Maximum) {

                    //We can use two way but the await is better cuz the user can do another thing on form not freezing
                    //the user UI thread 
                    //Thread.Sleep(500);
                    await Task.Delay(60);

                    progressBar1.Value += 1;
                    label1.Text = progressBar1.Value.ToString() + "%";
                    label1.Refresh();
                    progressBar1.Refresh();
                
                }      
            
            }

        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;

            if (!button1.Enabled)
            { //If the timer is currently not ticking (meaning that the progress bar is filled)
                button1.Enabled = true;
                label1.Text = "0%";
            }
        }
    }
}
