using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace SRMS
{
    public partial class Form1 : Form
    {

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
            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter("C:/Users/timon/Dropbox/COMS107/Assignment7/SRMS/marks.txt"))
            {
                sw.WriteLine("ID: " + id + "\n" + "name: " + name + "\n" + "Physics Score: " + physicsScore + "\n" + "Chemistry Score: " + chemScore + "\n" + "Math Score: " + mathScore + "\n");
            }

        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Please enter StudentId and click OK to retrieve", "Retrieve Student Record");

            int retrieveId = int.Parse(id);

            // Read and show each line from the file.
            bool isID = false;
            int count = 0;
            string line = "";
            string box = "";
            using (StreamReader sr = new StreamReader("C:/Users/timon/Dropbox/COMS107/Assignment7/SRMS/marks.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                        if (!line.Equals("") && line.Substring(4,1).Equals(id))
                    {
                        isID = true;
                    }
                    if (isID == true && count < 5)
                    {
                        box += line + "\n";
                        count++;
                    }
                }
            }
            
            retrieveTextBox.Text = box;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool isID = false;
            int count = 0;
            string line = "";
            string box = "";
            string id = Interaction.InputBox("Please enter StudentId and click OK to delete", "Delete Student Record");

            int deleteId = int.Parse(id);
                using (StreamReader sr = new StreamReader("C:/Users/timon/Dropbox/COMS107/Assignment7/SRMS/marks.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Equals("") && line.Substring(4, 1).Equals(id))
                        {
                            isID = true;
                        }
                        if (isID == true && count < 5)
                        {
                            count++;
                            continue;
                        }

                        sr.WriteLine(line);
                    }
                }

            MessageBox.Show("Student record Deleted!", "Delete");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
             
       }
    }
}
