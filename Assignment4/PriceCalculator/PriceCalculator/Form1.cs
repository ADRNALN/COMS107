using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double numberItems = 0.0;
            Double discountPercentage = 0.0;
            Double pricePerItem = 0.0;
            Double finalPrice = 0.0;

            numberItems = Convert.ToDouble(txtInput.Text);

            if (numberItems > 0 && numberItems <= 10)
            {
                pricePerItem = 1000;
                discountPercentage = 1.05;
                finalPrice = (numberItems * pricePerItem) / discountPercentage;
                String value = finalPrice.ToString();
                MessageBox.Show(value, "Information", MessageBoxButtons.OK);
            }

            else if (numberItems > 10 && numberItems <= 20)
            {
                pricePerItem = 1200;
                discountPercentage = 1.10;
                finalPrice = (numberItems * pricePerItem) / discountPercentage;
                String value = finalPrice.ToString();
                MessageBox.Show(value, "Information", MessageBoxButtons.OK);
            }

            else if (numberItems > 20 && numberItems <= 30)
            {
                pricePerItem = 1400;
                discountPercentage = 1.05;
                finalPrice = (numberItems * pricePerItem) / discountPercentage;
                String value = finalPrice.ToString();
                MessageBox.Show(value, "Information", MessageBoxButtons.OK);
            }

            else if (numberItems > 30)
            {
                pricePerItem = 1600;
                discountPercentage = 1.20;
                finalPrice = (numberItems * pricePerItem) / discountPercentage;
                String value = finalPrice.ToString();
                MessageBox.Show(value, "Information", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
