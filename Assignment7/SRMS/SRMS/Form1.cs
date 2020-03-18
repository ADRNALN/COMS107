using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRMS
{
    public partial class Form1 : Form
    {
        //intialize 2d array
        public string[,] studentId = new string[100,2];
        public int[,] studentClasses = new int[100, 4];

        public Form1()
        {
            InitializeComponent();
            retrieveTextBox.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int id;
            int physicsScore;
            int chemScore;
            int mathScore;
            try
            {
                id = int.Parse(txtID.Text);
                physicsScore = int.Parse(txtPhysics.Text);
                chemScore = int.Parse(txtChemistry.Text);
                mathScore = int.Parse(txtMath.Text);

            }
            catch (Exception)
            {
                throw;
            }
            //store id and name to first array
            studentId[id, 0] = id.ToString();
            studentId[id, 1] = name;

            //store other stuff into second array
            studentClasses[id, 0] = id;
            studentClasses[id, 1] = chemScore;
            studentClasses[id, 2] = mathScore;
            studentClasses[id, 3] = physicsScore;

        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Please enter StudentId and click OK to retrieve", "Retrieve Student Record");

            int retrieveId = int.Parse(id);
            string retrieveString = "";

            retrieveString += "Student ID: " +studentId[retrieveId, 0] + "\n";
            retrieveString += "Name: " + studentId[retrieveId, 1]  + "\n";

           
            retrieveString+= "Chemistry: " + studentClasses[retrieveId, 1] + "\n";
            retrieveString += "Mathmatics: "+studentClasses[retrieveId, 2] + "\n";
            retrieveString += "Physics: " +studentClasses[retrieveId, 3] + "\n";
            
            retrieveTextBox.Text = retrieveString;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           string id = Interaction.InputBox("Please enter StudentId and click OK to delete", "Delete Student Record");

            int deleteId = int.Parse(id);

            //delete id and name to first array
            studentId[deleteId, 0] = "";
            studentId[deleteId, 1] = "";

            //delete other stuff into second array
            studentClasses[deleteId, 0] = 0;
            studentClasses[deleteId, 1] = 0;
            studentClasses[deleteId, 2] = 0;
            studentClasses[deleteId, 3] = 0;

            MessageBox.Show("Student record Deleted!", "Delete");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
             
       }
    }
}
