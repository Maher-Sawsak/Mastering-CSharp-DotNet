using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Documents_Interface__MDI__Container
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmp Emp = new frmEmp();
            Emp.MdiParent = this;
            Emp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDep Dep = new frmDep();
            Dep.MdiParent = this;
            Dep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSalary Salaray = new frmSalary();
            Salaray.MdiParent = this;
            Salaray.Show();
        }
    }
}
