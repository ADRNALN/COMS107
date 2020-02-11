using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy_Awards
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "12 Years a Slave";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Birdman";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Spotlight";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Moonlight";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "The Shape of Water";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
