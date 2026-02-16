using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Line___ellipse___and_rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Paint1(object sender, PaintEventArgs e)
        {
            Color Black =Color.FromArgb(255,0,0,0);

            Pen pen = new Pen(Black);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // i should user the PaintEventArgs to dray somethind on the form.
            e.Graphics.DrawLine(pen, 100, 100, 100, 200);
            e.Graphics.DrawRectangle(pen, 300, 50, 100, 100);
            e.Graphics.DrawEllipse(pen, 325, 70, 50, 50);
        }
    }
}
