using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            boxInterest.Enabled = false;
        }

        // This first code block is utilizing arrays and buttons to calculate the total interest someone
        // owes for the last 6 months. It takes all the amounts in the array and adds
        // them up when the user clicks the Total Interest button. This also converts
        // the array to a string to make it usable in this use case
        private void btnInterest_Click(object sender, EventArgs e)
        {
            int[] paymentsDue = { 120, 500, 375, 340, 150, 150 };

            int sumPaymentsDue = paymentsDue.Sum();

            boxInterest.Text = "$" + sumPaymentsDue.ToString();
        }


    }

    // This is a simple for loop that while output all numbers between 0 and 10
    // when the project is initialized
    public class ForLoop
    {
        private void ExampleThree()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    // In this conditional statement you are given two variables x and y the system
    // will check if x is equal to y and print if true, else it will check to see if x is
    // greater than y and will then print, or else it will print that y is greater than x
    public class SimpleStatements
    {
        private void ExampleFour()
        {
            int x = 4;
            int y = 15;

            if (x == y)
            {
                Console.WriteLine("These two are equals");
            }
            else if (x > y)
            {
                Console.WriteLine("X is greater than y");
            }
            else
            {
                Console.WriteLine("Y is greater than x");
            }
        }
    }
} 
