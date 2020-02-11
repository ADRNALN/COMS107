using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometric_Shapes
{
    public partial class Form1 : Form
    {

        Double radius = 0.0;
        Double height = 0.0;
        Double surfaceArea = 0.0;
        Double volume = 0.0;
        Double pi = 3.14;
        public Form1()
        {
            InitializeComponent();
            surfaceAreaSphere.Enabled = false;
            volumeSphere.Enabled = false;
            surfaceAreaCylinder.Enabled = false;
            volumeCylinder.Enabled = false;
            surfaceAreaCone.Enabled = false;
            volumeCone.Enabled = false;
        }

        private void sphereButton_Click(object sender, EventArgs e)
        {
            radius = Convert.ToDouble(txtRadius.Text);
            height = Convert.ToDouble(txtHeight.Text);

            volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3.0);
            surfaceArea = 4.0 * pi * Math.Pow(radius, 2.0);

            surfaceAreaSphere.Text = Convert.ToString(surfaceArea);
            volumeSphere.Text = Convert.ToString(volume);
        }

        private void cylinderButton_Click(object sender, EventArgs e)
        {

            radius = Convert.ToDouble(txtRadius.Text);
            height = Convert.ToDouble(txtHeight.Text);

            volume = pi * Math.Pow(radius, 2.0) * height;
            surfaceArea = 2.0 * pi * Math.Pow(radius, 2.0) + 2.0 * pi * radius * height;

            surfaceAreaCylinder.Text = Convert.ToString(surfaceArea);
            volumeCylinder.Text = Convert.ToString(volume);
        }

        private void coneButton_Click(object sender, EventArgs e)
        {
            radius = Convert.ToDouble(txtRadius.Text);
            height = Convert.ToDouble(txtHeight.Text);

            volume = (1.0 / 3.0) * pi * radius * radius * height; ;
            surfaceArea = pi * radius * (radius + Math.Sqrt(radius * radius + height * height)); ;

            surfaceAreaCone.Text = Convert.ToString(surfaceArea);
            volumeCone.Text = Convert.ToString(volume);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
