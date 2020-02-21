using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtYearOne.Enabled = false;
            txtAnswer.Enabled = false;
            txtYearOne.Text = "2020";
        }

        private void txtPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifys it is numerical
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allowing decimals
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifys it is numerical
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allowing decimals
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtYearTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifys it is numerical
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allowing decimals
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // identify variables
            Double Principal = 0.0;
            Double ROI = 0.0;
            Double Interest = 0.0;
            int compoundFreq = 4;
            int year = 2020;
            int endYear = 0;
            int numberYears = 0;

            // equations
            endYear = Int16.Parse(txtYearTwo.Text);
            Principal = Convert.ToDouble(txtPrincipal.Text);
            ROI = Convert.ToDouble(txtInterest.Text);
            numberYears = endYear - year;

            // calculations
            Interest = Principal * ((1 + ROI / compoundFreq) * (Math.Pow(compoundFreq, - numberYears)) - 1);
            String endInterest = Interest.ToString();

            // loop
            while(year <= endYear)
            {
                txtAnswer.Text = ("Year End Interest: " + endInterest);
                year++;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
