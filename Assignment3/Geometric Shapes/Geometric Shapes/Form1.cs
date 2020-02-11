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
        Double surfaceAreaCylinder = 0.0;
        Double volumeCylinder = 0.0;
        Double surfaceAreaSphere = 0.0;
        Double volumeSphere = 0.0;
        Double surfaceAreaCone = 0.0;
        Double volumeCone = 0.0;
        Double pi = 3.14;

        public Form1()
        {
            InitializeComponent();
            solutionTextBox.Enabled = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Converting user input to number
            radius = Convert.ToDouble(txtRadius.Text);
            height = Convert.ToDouble(txtHeight.Text);

            // Sphere calculation
            volumeSphere = (4.0 / 3.0) * pi * Math.Pow(radius, 3.0);
            surfaceAreaSphere = 4.0 * pi * Math.Pow(radius, 2.0);

            // Cylinder calculation
            volumeCylinder = pi * Math.Pow(radius, 2.0) * height;
            surfaceAreaCylinder = 2.0 * pi * Math.Pow(radius, 2.0) + 2.0 * pi * radius * height;

            // Cone calculation
            volumeCone = (1.0 / 3.0) * pi * radius * radius * height;
            surfaceAreaCone = pi * radius * (radius + Math.Sqrt(radius * radius + height * height));

            // Sphere function
            if (radioSphere.Checked)
            {
                if (checkBoxSurface.Checked && checkBoxVolume.Checked)
                {
                    solutionTextBox.Text = "Volume of Sphere: " + Convert.ToString(surfaceAreaSphere) + "\n" + "Surface Area of Sphere: " + Convert.ToString(volumeSphere);
                }

                else if (checkBoxSurface.Checked)
                {
                    solutionTextBox.Text = "Surface Area of Sphere: " + Convert.ToString(surfaceAreaSphere);
                }

                else if (checkBoxVolume.Checked)

                {
                    solutionTextBox.Text = "Volume of Sphere: " + Convert.ToString(volumeSphere);
                }
            }

            // Cylinder function
            if (radioCylinder.Checked)
            {
                if (checkBoxSurface.Checked && checkBoxVolume.Checked)
                {
                    solutionTextBox.Text = "Volume of Cylinder: " + Convert.ToString(surfaceAreaCylinder) + "\n" + "Surface Area of Cylinder: " + Convert.ToString(volumeCylinder);
                }

                else if (checkBoxSurface.Checked)
                {
                    solutionTextBox.Text = "Surface Area of Cylinder: " + Convert.ToString(surfaceAreaCylinder);
                }

                else if (checkBoxVolume.Checked)

                {
                    solutionTextBox.Text = "Volume of Cylinder: " + Convert.ToString(volumeCylinder);
                }
            }

            // Cone function
            if (radioCone.Checked)

                if (checkBoxSurface.Checked && checkBoxVolume.Checked)
                {
                    solutionTextBox.Text = "Volume of Cone: " + Convert.ToString(surfaceAreaCone) + "\n" + "Surface Area of Cone: " + Convert.ToString(volumeCone);
                }

                else if (checkBoxSurface.Checked)
                {
                    solutionTextBox.Text = "Surface Area of Cone: " + Convert.ToString(surfaceAreaCone);
                }

                else if (checkBoxVolume.Checked)

                {
                    solutionTextBox.Text = "Volume of Cone: " + Convert.ToString(volumeCone);
                }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
