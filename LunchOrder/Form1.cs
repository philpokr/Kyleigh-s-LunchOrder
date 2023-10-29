using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        const double Tax = 7.75d;
        const double Hamburger = 6.95d;
        const double pizza = 5.95d;
        const double Salad = 4.95d;

        double AddOn = 0.0d; //To hold add on sum


        double AddOnPrice = 0.0d; //To hold Add On Price
        double Order_Total = 0.0d; //To Hold Order Total

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (radio695.Checked)
                Order_Total += Hamburger;
            if (radio595.Checked)
                Order_Total += pizza;
            if (radio495.Checked)
                Order_Total += Salad;

            Order_Total += AddOn;

            txtSubtotal.Text = "$" + String.Format("{0:0.00}", Order_Total);

            double tax = (Order_Total * 7.75d) / 100;

            txtSalesTax.Text = "$" + String.Format("{0:0.00}", tax);

            txtOrderTotal.Text = "$" + String.Format("{0:0.00}", (Order_Total + tax));
        }

        private void addon1_CheckedChanged(object sender, EventArgs e)
        {
            if (addon1.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;
        }
        //Kyleigh Philpott
        private void ClearTotals()
        {
            AddOn = 0.0d;
            addon1.Checked = false;
            addon2.Checked = false;
            addon3.Checked = false;
        }

        private void addon2_CheckedChanged(object sender, EventArgs e)
        {
            if (addon2.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;
        }

        private void addon3_CheckedChanged(object sender, EventArgs e)
        {
            if (addon3.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;
        }
        //Kyleigh Philpott
        private void ClearAddOns()
        {
            AddOn = 0.0d;
            addon1.Checked = false;
            addon2.Checked = false;
            addon3.Checked = false;
        }
        //Kyleigh Philpott
        private void radio695_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            if (radio695.Checked)
            {
                groupBox2.Text = "Add-on items ($.75/each)";
                addon1.Text = "Lettuce, tomatoes, onions";
                addon2.Text = "Ketchup, mustard and mayo";
                addon3.Text = "French Fries";
                AddOnPrice = 0.75d;
            }
        }
        //Kyleigh Philpott
        private void radio595_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            if (radio595.Checked)
            {
                groupBox2.Text = "Add-on items ($.75/each)";
                addon1.Text = "pinenapple";
                addon2.Text = "cheese";
                addon3.Text = "pepperoni";
                AddOnPrice = 0.75d;
            }
        }
        //Kyleigh Philpott
        private void radio495_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
            ClearAddOns();
            if (radio495.Checked)
            {
                groupBox2.Text = "Add-on items ($.75/each)";
                addon1.Text = "bacon";
                addon2.Text = "croutons";
                addon3.Text = "egg";
                AddOnPrice = 0.75d;
            }
        }
    }
}
