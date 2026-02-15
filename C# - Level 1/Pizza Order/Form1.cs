using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order
{

   

    public partial class frmMenueForm : Form
    {

        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbMeduim.Checked)
            {
                lblSize.Text = "Meduim";
                return;
            }
            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }
            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Think Crust";
                return;
            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings += "Extra Chees";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkGreenPapper.Checked)
            {
                sToppings += ", Green Pappe";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }
            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (sToppings.StartsWith(","))
            {
                //trim if there is any space in any sides will deleted.
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }
            lblTopping.Text = sToppings;
        }

        void UpdateTotalPrice()
        {

            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateWhereToEat() {
            if (rbEatIn.Checked) {

                lblWhereToEat.Text = "Eat In";
                return;
            }
            if (rbTakeOut.Checked) {
                lblWhereToEat.Text = "Take Out";
                return;
            }
        
        }

        void UpdateOrderSummary() {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }
        float GetSelectedSizePrice()
        {

            //it must return a value or will give compilation error.
            if (rbSmall.Checked)
            {

                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }
            else
            {

                return Convert.ToSingle(rbLarge.Tag);
            }

        }

        float CalculateToppingsPrice()
        {

            float ToppingsPrice = 0f;

            if (chkExtraCheese.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkOlives.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPapper.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkGreenPapper.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkTomatoes.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            return ToppingsPrice;
        }

        float GetSelectedCrustPrice()
        {

            if (rbThickCrust.Checked)
            {

                return Convert.ToSingle(rbThickCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice();
        }

        public frmMenueForm()
        {
            InitializeComponent();
        }


        //here when the form load 
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SizeLable_Click(object sender, EventArgs e)
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }

        private void TotalPriceLable_Click(object sender, EventArgs e)
        {
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Order ?", "Confirm Order!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {

                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrder.Enabled = false;
                MessageBox.Show("Done Successfully .", "Order Status", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPapper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {

            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;


            rbSmall.Checked = true;
            //for place eating
            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;

            //for topping.
            chkExtraCheese.Checked = false;
            chkGreenPapper.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
            chkMushrooms.Checked = false;

            //for crust also.
            rbThinCrust.Checked = false;
            rbThickCrust.Checked = false;


            btnOrder.Enabled = true;
        }

        
    }
}
