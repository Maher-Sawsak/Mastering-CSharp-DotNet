using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         void UpdateTurn() {

            if (lblTurn.Text == "Player 1")
            {
                lblTurn.Text = "Player 2";
            }
            else {
                lblTurn.Text = "Player 1";
            }
             
        }


        bool IsChosen(PictureBox pbCurrent) {

            if (Convert.ToString(pbCurrent.Tag) != "Empty")
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return true;
            }
            else { 
            
            }
            return false;
        
        }

        void UpdateWinner() {

            if (Convert.ToString(pictureBox1.Tag) == "X" && Convert.ToString(pictureBox2.Tag) == "X"
                && Convert.ToString(pictureBox3.Tag) == "X")
            {
                lblWinner.Text = "Player 1";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.BackColor = Color.Green;
                pictureBox2.BackColor = Color.Green;
                pictureBox3.BackColor = Color.Green;
                return;
            }
            else if (Convert.ToString(pictureBox4.Tag) == "X" && Convert.ToString(pictureBox5.Tag) == "X"
                && Convert.ToString(pictureBox6.Tag) == "X")
            {
                lblWinner.Text = "Player 1";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox4.BackColor = Color.Green;
                pictureBox5.BackColor = Color.Green;
                pictureBox6.BackColor = Color.Green;
                return;
            }

            else if (Convert.ToString(pictureBox7.Tag) == "X" && Convert.ToString(pictureBox8.Tag) == "X"
                && Convert.ToString(pictureBox9.Tag) == "X")
            {
                lblWinner.Text = "Player 1";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }
            else if (Convert.ToString(pictureBox1.Tag) == "X" && Convert.ToString(pictureBox4.Tag) == "X"
 && Convert.ToString(pictureBox7.Tag) == "X")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }
            else if (Convert.ToString(pictureBox2.Tag) == "X" && Convert.ToString(pictureBox7.Tag) == "X"
            && Convert.ToString(pictureBox5.Tag) == "X")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }
            else if (Convert.ToString(pictureBox3.Tag) == "X" && Convert.ToString(pictureBox6.Tag) == "X"
            && Convert.ToString(pictureBox9.Tag) == "X")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }
            else if (Convert.ToString(pictureBox1.Tag) == "X" && Convert.ToString(pictureBox5.Tag) == "X"
               && Convert.ToString(pictureBox9.Tag) == "X")
            {

                lblWinner.Text = "Player 1";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.BackColor = Color.Green;
                pictureBox5.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;
            }
            //for o
            else if (Convert.ToString(pictureBox1.Tag) == "O" && Convert.ToString(pictureBox2.Tag) == "O"
             && Convert.ToString(pictureBox3.Tag) == "O")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.BackColor = Color.Green;
                pictureBox2.BackColor = Color.Green;
                pictureBox3.BackColor = Color.Green;
                return;
            }
            else if (Convert.ToString(pictureBox4.Tag) == "O" && Convert.ToString(pictureBox5.Tag) == "O"
                && Convert.ToString(pictureBox6.Tag) == "O")
            {

                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox4.BackColor = Color.Green;
                pictureBox5.BackColor = Color.Green;
                pictureBox6.BackColor = Color.Green;
                return;
            }
            else if (Convert.ToString(pictureBox7.Tag) == "O" && Convert.ToString(pictureBox8.Tag) == "O"
                && Convert.ToString(pictureBox9.Tag) == "O")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }
            else if (Convert.ToString(pictureBox3.Tag) == "O" && Convert.ToString(pictureBox5.Tag) == "O"
            && Convert.ToString(pictureBox7.Tag) == "O")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }
            else if (Convert.ToString(pictureBox1.Tag) == "O" && Convert.ToString(pictureBox4.Tag) == "O"
            && Convert.ToString(pictureBox7.Tag) == "O")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }
            else if (Convert.ToString(pictureBox2.Tag) == "O" && Convert.ToString(pictureBox7.Tag) == "O"
            && Convert.ToString(pictureBox5.Tag) == "O")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }
            else if (Convert.ToString(pictureBox3.Tag) == "O" && Convert.ToString(pictureBox6.Tag) == "O"
            && Convert.ToString(pictureBox9.Tag) == "O")
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox7.BackColor = Color.Green;
                pictureBox8.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;

            }

            else if (Convert.ToString(pictureBox1.Tag) == "O" && Convert.ToString(pictureBox5.Tag) == "O"
               && Convert.ToString(pictureBox9.Tag) == "O")
            {

                lblWinner.Text = "Player 2";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.BackColor = Color.Green;
                pictureBox5.BackColor = Color.Green;
                pictureBox9.BackColor = Color.Green;
                return;
            }
            else if (Convert.ToString(pictureBox1.Tag) == "Empty" || Convert.ToString(pictureBox2.Tag) == "Empty" ||
                    Convert.ToString(pictureBox3.Tag) == "Empty" || Convert.ToString(pictureBox4.Tag) == "Empty" ||
                    Convert.ToString(pictureBox5.Tag) == "Empty" || Convert.ToString(pictureBox6.Tag) == "Empty" ||
                    Convert.ToString(pictureBox7.Tag) == "Empty" || Convert.ToString(pictureBox8.Tag) == "Empty" ||
                    Convert.ToString(pictureBox9.Tag) == "Empty")
            {


                lblWinner.Text = "In Progress";
                return;
            }
            else {
                lblWinner.Text = "Draw";
                MessageBox.Show("Game Over!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }


        }
       void UpdateImage(PictureBox pbTemp) {
            this.Tag = "Updated";
          
            if (lblTurn.Text == "Player 1")
            {
                pbTemp.Image = Properties.Resources.Ximg;
            }
            else if (lblTurn.Text == "Player 2")
            {
                pbTemp.Image = Properties.Resources.Oimg;
            }
            else {
                pbTemp.Image = Properties.Resources.Question_img;

            }

            if (lblTurn.Text == "Player 1")
            {

                pbTemp.Tag = "X";

            }
            else { 
            
                pbTemp.Tag = "O";
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (IsChosen(pictureBox1))
                return;
     
      
            UpdateImage(pictureBox1);
            UpdateWinner();
            UpdateTurn();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen pen = new Pen(white);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, 320, 167, 620, 167);
            e.Graphics.DrawLine(pen, 320, 246, 620, 246);
            e.Graphics.DrawLine(pen, 420, 88, 420, 315);
            e.Graphics.DrawLine(pen, 530, 88, 530, 320);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
         
            this.Text = $"X = {e.X} , Y = {e.Y}";
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (IsChosen(pictureBox2))
                return;



            UpdateImage(pictureBox2);
            UpdateWinner();
            UpdateTurn();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (IsChosen(pictureBox3))
               return;
            


            UpdateImage(pictureBox3);
            UpdateWinner();
            UpdateTurn();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (IsChosen(pictureBox4))
                return;



            UpdateImage(pictureBox4);
            UpdateWinner();
            UpdateTurn();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (IsChosen(pictureBox5))
                return;



            UpdateImage(pictureBox5);
            UpdateWinner();
            UpdateTurn();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (IsChosen(pictureBox6))
                return;



            UpdateImage(pictureBox6);
            UpdateWinner();
            UpdateTurn();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (IsChosen(pictureBox7))
                return;



            UpdateImage(pictureBox7);
            UpdateWinner();
            UpdateTurn();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (IsChosen(pictureBox8))
                return;



            UpdateImage(pictureBox8);
            UpdateWinner();
            UpdateTurn();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (IsChosen(pictureBox9))
                return;



            UpdateImage(pictureBox9);
            UpdateWinner();
            UpdateTurn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Question_img;
            pictureBox2.Image = Properties.Resources.Question_img;
            pictureBox3.Image = Properties.Resources.Question_img;
            pictureBox4.Image = Properties.Resources.Question_img;
            pictureBox5.Image = Properties.Resources.Question_img;
            pictureBox6.Image = Properties.Resources.Question_img;
            pictureBox7.Image = Properties.Resources.Question_img;
            pictureBox8.Image = Properties.Resources.Question_img;
            pictureBox9.Image = Properties.Resources.Question_img;


            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;

            pictureBox1.Tag = "Empty";
            pictureBox2.Tag = "Empty";
            pictureBox3.Tag = "Empty";
            pictureBox4.Tag = "Empty";
            pictureBox5.Tag = "Empty";
            pictureBox6.Tag = "Empty";
            pictureBox7.Tag = "Empty";
            pictureBox8.Tag = "Empty";
            pictureBox9.Tag = "Empty";

            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            button1_Click(sender, e);
            btnRestart.Text = "Restart Game";
           
        }
    }
}
