using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtAnswer.Enabled = false;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age = 0;
            string model = comboModel.Text;
            string name = txtName.Text;
            int Year = int.Parse(listYear.Text);
            Double basePremium = 1000;
            Double discount = 0.0;
            Double premium = 0.0;

            if(age > 15 && age < 25)
            {
                if (Year < 2015)
                {
                    discount = 0.05;
                }
                else
                {
                    discount = 0.25;
                }
            }
            else if (age > 25 && age < 35)
            {
                if (Year < 2015)
                {
                    discount = 0.1;
                }
                else
                {
                    discount = 0.05;
                }
            }
            else if (age > 35 && age < 45)
            {
                if (Year < 2016)
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.075;
                }
            }
            else if (age > 45 && age < 55)
            {
                if (Year < 2016)
                {
                    discount = 0.2;
                }
                else
                {
                    discount = 0.1;
                }
            }
            else if (Year < 2016)
            {
                discount = 0.3;
            }
            else
            {
                discount = 0.15;
            }

            premium = basePremium - discount * basePremium;
            txtAnswer.Text = "Premium schedule for " + name + ";" + " Car model is " + model + " and year is " + Year + "\nPremium as of now = " + basePremium + "\n";

            for (int x = 0; x < 4; x++)
            {
                int month = 0;

                if (x == 0)
                {
                    month = 6;
                }
                else if (x == 1)
                {
                    month = 12;
                }
                else if (x == 2)
                {
                    month = 18;
                }
                else
                {
                    month = 24;
                }

                premium = premium - premium * x * 0.025;
                premium = Math.Round(premium, 1);
                String Answer = premium.ToString();
                txtAnswer.Text += "Premium after " + month + " months $" + Answer + "\n";
           }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
