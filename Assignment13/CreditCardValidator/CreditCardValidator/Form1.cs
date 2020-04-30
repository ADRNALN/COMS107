using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string userInput = cardNumber.ToString();
            int cardNumberDigits = userInput.Length;

            int cardSum = 0;
            bool isSecond = false;

            for (int i = cardNumberDigits - 1; i >= 0; i--)
            {

                int d = userInput[i] - '0';

                if (isSecond == true)
                    d = d * 2;

                cardSum += d / 10;
                cardSum += d % 10;

                isSecond = !isSecond;
            }

            if (isSecond == true)
            {
                MessageBox.Show("This is a valid card", "Validation");
            }
            else
            {
                MessageBox.Show("This is an invalid card", "Validation");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
