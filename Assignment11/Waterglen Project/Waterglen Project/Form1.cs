using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterglen_Project
{
    public partial class Form1 : Form
    {
        int[] horseOne = { 0, 1, 0, 3, 2 };
        int[] horseTwo = { 1, 0, 2, 0, 0 };
        int[] horseThree = { 0, 3, 0, 1, 0 };
        int[] horseFour = { 3, 2, 1, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            txtFirst.Enabled = false;
            txtSecond.Enabled = false;
            txtThird.Enabled = false;
            txtDNP.Enabled = false;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            object Choice = listBox1.SelectedItem;
            int first = 0, second = 0, third = 0, not = 0;
            if (Choice.Equals("Horse 1"))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (horseOne[i] == 0)
                    {
                        not++;
                    }
                    if (horseOne[i] == 1)
                    {
                        first++;
                    }
                    if (horseOne[i] == 2)
                    {
                        second++;
                    }
                    if (horseOne[i] == 3)
                    {
                        third++;
                    }
                }
            }
            if (Choice.Equals("Horse 2"))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (horseTwo[i] == 0)
                    {
                        not++;
                    }
                    if (horseTwo[i] == 1)
                    {
                        first++;
                    }
                    if (horseTwo[i] == 2)
                    {
                        second++;
                    }
                    if (horseTwo[i] == 3)
                    {
                        third++;
                    }
                }
            }
            if (Choice.Equals("Horse 3"))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (horseThree[i] == 0)
                    {
                        not++;
                    }
                    if (horseThree[i] == 1)
                    {
                        first++;
                    }
                    if (horseThree[i] == 2)
                    {
                        second++;
                    }
                    if (horseThree[i] == 3)
                    {
                        third++;
                    }
                }
            }
            if (Choice.Equals("Horse 4"))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (horseFour[i] == 0)
                    {
                        not++;
                    }
                    if (horseFour[i] == 1)
                    {
                        first++;
                    }
                    if (horseFour[i] == 2)
                    {
                        second++;
                    }
                    if (horseFour[i] == 3)
                    {
                        third++;
                    }
                }
            }
            if (Choice.Equals("All Horses"))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (horseOne[i] == 0)
                    {
                        not++;
                    }
                    if (horseOne[i] == 1)
                    {
                        first++;
                    }
                    if (horseOne[i] == 2)
                    {
                        second++;
                    }
                    if (horseOne[i] == 3)
                    {
                        third++;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (horseTwo[i] == 0)
                    {
                        not++;
                    }
                    if (horseTwo[i] == 1)
                    {
                        first++;
                    }
                    if (horseTwo[i] == 2)
                    {
                        second++;
                    }
                    if (horseTwo[i] == 3)
                    {
                        third++;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (horseThree[i] == 0)
                    {
                        not++;
                    }
                    if (horseThree[i] == 1)
                    {
                        first++;
                    }
                    if (horseThree[i] == 2)
                    {
                        second++;
                    }
                    if (horseThree[i] == 3)
                    {
                        third++;
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    if (horseFour[i] == 0)
                    {
                        not++;
                    }
                    if (horseFour[i] == 1)
                    {
                        first++;
                    }
                    if (horseFour[i] == 2)
                    {
                        second++;
                    }
                    if (horseFour[i] == 3)
                    {
                        third++;
                    }
                }
            }
            txtFirst.Text = first.ToString();
            txtSecond.Text = second.ToString();
            txtThird.Text = third.ToString();
            txtDNP.Text = not.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
