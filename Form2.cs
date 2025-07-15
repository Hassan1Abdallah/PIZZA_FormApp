using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                label2.Text = "Size : Small";
                sizePrice = 20;
                CalculateTotal();
            }
 
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMeduim.Checked)
            {
                label2.Text = "Size : Meduim";
                sizePrice = 30;
                CalculateTotal();
            }
            

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                label2.Text = "Size : Large";
                sizePrice = 40;
                CalculateTotal();
            }
        }

        private void chkChees_CheckedChanged(object sender, EventArgs e)
        {
            string word;
            if (chkChees.Checked)
            {
                word = " Extra Chees, ";
                toppingsPrice += 5;
                CalculateTotal();
            }
            else
            {
                word = "";
            }
            label3.Text += word;
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            string word;
            if (chkMushrooms.Checked)
            {
                word = " Mushrooms, ";
                toppingsPrice += 5;
                CalculateTotal();
            }
            else
            {
                word = "";
            }
            label3.Text += word;
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            string word;
            if (chkTomatoes.Checked)
            {
                word = " Tomatoes, ";
                toppingsPrice += 5;
                CalculateTotal();
            }
            else
            {
                word = "";
            }
            label3.Text += word;
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            string word;
            if (chkOnion.Checked)
            {
                word = " Onion, ";
                toppingsPrice += 5;
                CalculateTotal();
            }
            else
            {
                word = "";
            }
            label3.Text += word;
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            string word;
            if (chkOlives.Checked)
            {
                word = " Olives, ";
                toppingsPrice += 5;
                CalculateTotal();
            }
            else
            {
                word = "";
            }
            label3.Text += word;
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            string word;
            if (chkPeppers.Checked)
            {
                word = " Green Peppers, ";
                toppingsPrice += 5;
                CalculateTotal();
            }
            else
            {
                word = "";
            }
            label3.Text += word;
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
            {
                label4.Text = "Crust Type : Thin";
                crustPrice = 0;
                CalculateTotal();
            }
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked)
            {
                label4.Text = "Crust Type : Thick";
                crustPrice = 10;
                CalculateTotal();
            }
        }

        private void rbEatIN_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIN.Checked)
            {
                label5.Text = "Where to eat : Eat in";
            }
        }

        private void rbTakeout_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeout.Checked)
            {
                label5.Text = "Where to eat : Take out";
            }
        }
        int sizePrice = 0;
        int crustPrice = 0;
        int toppingsPrice = 0;
        int totalPrice = 0;

        private void CalculateTotal()
        {
            totalPrice = sizePrice + crustPrice + toppingsPrice;
            lbClcTotal.Text = "Total Price: $" + totalPrice.ToString("0.00");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to confirm the order?", "Confirm Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCrust.Enabled = false;
                gbEat.Enabled = false;
                gbSize.Enabled = false;
                gbSummary.Enabled = false;
                gbToppings.Enabled = false;
                btnOrder.Enabled = false;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gbCrust.Enabled = true;
            gbEat.Enabled = true;
            gbSize.Enabled = true;
            gbSummary.Enabled = true;
            gbToppings.Enabled = true;
            btnOrder.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
