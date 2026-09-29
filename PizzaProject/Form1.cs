using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float CalculateToppingsPrice()
        {
            float TotalToppingPrice = 0;

            if (chkExtraCheese.Checked)
                TotalToppingPrice += Convert.ToSingle(chkExtraCheese.Tag);
            if (chkGreenPeppers.Checked)
                TotalToppingPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            if (chkMushrooms.Checked)
                TotalToppingPrice += Convert.ToSingle(chkMushrooms.Tag);
            if (chkTomatoes.Checked)
                TotalToppingPrice += Convert.ToSingle(chkTomatoes.Tag);
            if (chkOnion.Checked)
                TotalToppingPrice += Convert.ToSingle(chkOnion.Tag);
            if (chkOlives.Checked)
                TotalToppingPrice += Convert.ToSingle(chkOlives.Tag);

            return TotalToppingPrice;
        }

        float GetSelectedCrustPrice()
        {
            float SelectedCrust = 0;

            if (rbThinCrust.Checked)
                SelectedCrust += Convert.ToSingle(rbThinCrust.Tag);

            if (rbThickCrust.Checked)
                SelectedCrust += Convert.ToSingle(rbThickCrust.Tag);

            return SelectedCrust;
        }

       float CalculateTotalPrice()
        {
            return (GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice());
        }
        void UpdateTotalPrice()
        {
            lblPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
                lblSize.Text = "Small";

        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Think Crust";
                return;
            }

            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }


        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;


        }
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereEat.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereEat.Text = "Take Out.";
                return;
            }

        }
        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        void ResetForm()
        {

            //reset Groups
            gbSize.Enabled = true;
            gbTopping.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereEat.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rbThinCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrderPizza.Enabled = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblSize.Text = gbSize.Text;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize() ;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbTopping.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereEat.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
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

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
    }
}
