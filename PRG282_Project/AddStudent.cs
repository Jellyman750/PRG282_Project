using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG282_Project
{
    public partial class AddStudent : Form
    {

        private void label3_Click(object sender, EventArgs e)
        {

        }
        DataHandler handler = new DataHandler();

        public AddStudent()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string name = txtName.Text;        // Name comes first
            int age = int.Parse(txtAge.Text);  // Surname comes second
            string course = txtCourse.Text;

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age.ToString()) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                handler.AddStudent(studentID, name, age, course);
                MessageBox.Show("Student added successfully.");
                this.Close(); // Close the form after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
