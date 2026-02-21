using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            //show here will return what the user pressed

            if (colorDialog1.ShowDialog() == DialogResult.OK) {

                textBox1.BackColor = colorDialog1.Color;
                
            }
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            //show here will return what the user pressed
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
          
                textBox1.ForeColor = colorDialog1.Color;
          
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowHelp = true;

            //in the dialog font will be the same to the text box font at start if u didn't write this line will set the default font .
            fontDialog1.Font = textBox1.Font; 

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            //its an event for apply button in the font dialog.

            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;

        
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            //when u click on the save button will move set the Initial path to C or any thing between " ". 
            saveFileDialog1.InitialDirectory = @"C:\";

           //this will add to the name .txt if you didn't put it by default will that is inside double quotations ""
            saveFileDialog1.DefaultExt = ".txt";

            saveFileDialog1.Title = "Download Project";

            //it will give us the filter that will just show file in this Extension,
            //we use this Extension to show all files *.* and her * means any .
            //syntax saveFileDialog1.Filter ="Description | *.ExtensionName";


            saveFileDialog1.Filter ="just (*txt files) |*.txt  | All files | *.*";

            //it will be as a default filter when click on open files.
            openFileDialog1.FilterIndex = 1;

            //it will not actually save the file it will return the full path for user's chosen.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                MessageBox.Show(saveFileDialog1.FileName);
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //here the OpenFile dialog for browser and choice a file not to save will be button open not save.

            openFileDialog1.InitialDirectory = @"C:/";
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Filter = "Text Files |*.txt | All Files |*.*";

            //it will be as a default filter when click on open files.
            openFileDialog1.FilterIndex = 1;

            //here u can only choose one file and it will return the path for the chosen file .
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                MessageBox.Show(openFileDialog1.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //here you can choice multi files not just one so u need to this property to be true.

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                //if the user selected multi file will be multi path and stores in FileNames 
                //so we need foreach to access all selected names.
                foreach (string filePath in openFileDialog1.FileNames) {
                    MessageBox.Show(filePath);
                }

            }

        }
    }
}
