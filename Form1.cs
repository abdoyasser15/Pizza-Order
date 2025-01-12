using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    enum enPricesOfSize
    {
        Small = 10 , Medium = 20 , Large = 30
    }
    enum enPricesType
    {
        Thin = 7 , Thick = 9
    }
    enum enToppings
    {
        ExtraCheese = 5 , Onion = 4 , Mushroms = 10 , Olives = 5 , Tomatoes = 5 , GreenPeppers = 7   
    }
    public partial class Form1 : Form
    {
         int Total_sizes()
         {
            if (rdSmall.Checked)
            {
                return (byte)enPricesOfSize.Small;
            }else if (rdMedium.Checked)
            {
                return (byte)enPricesOfSize.Medium;
            }
            else
            {
                return (byte)enPricesOfSize.Large;
            }
         }
        int Total_Prices_Type()
        {
            if (rdThinType.Checked) return (byte)enPricesType.Thin;
            else if (rdThickType.Checked) return (byte)enPricesType.Thick;
            else return 0;
        }
        int Total_Prices_Toppings()
        {
            int total = 0;
            if (chkcheese.Checked) total+=(byte)enToppings.ExtraCheese;
            if (chkTomatoes.Checked)total += (byte)enToppings.Tomatoes;
            if (chkGreenPeppers.Checked) total += (byte)enToppings.GreenPeppers;
            if (chkOlives.Checked) total += (byte)enToppings.Olives;
            if (chkOnions.Checked) total += (byte)enToppings.Onion;
            if (chkMushroms.Checked) total += (byte)enToppings.Mushroms;
            return total;
        }
        void Disable()
        {
            gpSize.Enabled = false;
            gpToppings.Enabled = false;
            gpType.Enabled = false;
            gpWhereToEat.Enabled = false;
            numericUpDown1.Enabled = false;
        }
        void Enable()
        {
            gpSize.Enabled = true;
            gpToppings.Enabled = true;
            gpType.Enabled = true;
            gpWhereToEat.Enabled = true;
            numericUpDown1.Enabled = true;
        }
        void Updat_Toppings()
        {
            string Toppings = "";
            if (chkcheese.Checked)
            {
                Toppings += "Extra Cheese";
            }
            if (chkOnions.Checked)
            {
                Toppings += " ,Onions";
            }
            if (chkMushroms.Checked)
            {
                Toppings += " ,Mushroms";
            }
            if (chkOlives.Checked)
            {
                Toppings += " ,Olives";
            }
            if (chkTomatoes.Checked)
            {
                Toppings += " ,Tomatoes";
            }
            if (chkGreenPeppers.Checked)
            {
                Toppings += " ,GreenPeppers";
            }
            if (Toppings=="")
            {
                Toppings = "No Toppings";
            }
            lbTo.Text = Toppings;  
        }
        int Total_Prices()
        {
            return (Total_sizes() + Total_Prices_Type() + Total_Prices_Toppings())*(int)(numericUpDown1.Value);
        }
        void Update_Price()
        {
            lbPrice.Text = "$"+Total_Prices().ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void gpOrderSummary_Enter(object sender, EventArgs e)
        {

        }
        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            if (rdSmall.Checked) {
                lbTextSize.Text = "Small";
            }
        }
        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            if (rdMedium.Checked) { 
                lbTextSize.Text = "Medium";
            }
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            if (rdLarge.Checked) 
            { 
                lbTextSize.Text = "Large"; 
            }
        }
        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            if (rdEatIn.Checked)
            {
                lbTakeinOrOut.Text = "Eat In";
            }
        }
        private void rdEatOut_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            if (rdEatOut.Checked)
            {
                lbTakeinOrOut.Text = "Take Out";
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            if (rdThinType.Checked)
            {
                lbCrustType.Text = "Thin";
            }
        }
        private void rdThickType_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            if (rdThickType.Checked) {
                lbCrustType.Text = "Thick";
            }
        }
        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure  To Submit Your Order ? ","Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                MessageBox.Show("Order Submitted Sucessfully");
                Disable();
            }
        }
        private void btResetOrder_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void chkcheese_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            Updat_Toppings();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            Updat_Toppings();
        }

        private void chkMushroms_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            Updat_Toppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            Updat_Toppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            Updat_Toppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            Update_Price();
            Updat_Toppings();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Update_Price();
            Updat_Toppings();
        }
    }
}