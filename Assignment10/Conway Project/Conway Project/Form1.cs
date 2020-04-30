using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway_Project
{
    public partial class Form1 : Form
    {
        int[] domesticSales = { 100000, 90000, 75000, 88000, 125000, 63000 };
        int[] internationalSales = { 150000, 120000, 210000, 50000, 220000, 80000 };
        public Form1()
        {
            InitializeComponent();
            totalDomestic.Enabled = false;
            totalInternational.Enabled = false;
            totalCompany.Enabled = false;
            // 1
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            int sumDomestic = domesticSales.Sum();
            int sumInternational = internationalSales.Sum();
            int sumTotal = sumDomestic + sumInternational;

            totalDomestic.Text = "$" + sumDomestic.ToString();
            totalInternational.Text = "$" + sumInternational.ToString();
            totalCompany.Text = "$" + sumTotal.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
