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
using System.IO;

namespace PRG282_Project
{
    public partial class AddStudent : Form
    {

        private void label3_Click(object sender, EventArgs e)
        {

        }
        DataHandler handler = new DataHandler();
        Student student = new Student();

        public AddStudent()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student.StudentID = int.Parse((txtStudentID.Text));
            student.Name = (txtName.Text);
            student.Age = int.Parse((txtAge.Text));
            student.Course = txtAge.Text;

            if (string.IsNullOrEmpty(student.StudentID.ToString()) || string.IsNullOrEmpty(student.Name) || string.IsNullOrEmpty(student.Age.ToString()) || string.IsNullOrEmpty(student.Course))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                handler.AddStudent(student.StudentID.ToString(), student.Name, student.Age, student.Course);
                MessageBox.Show("Student added successfully.");
                this.Close(); // Close the form after saving


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }



            string filepath = "AddedStudents.txt";
            handler.AddList.Add(new Student(student.StudentID, student.Name, student.Age, student.Course));


            using (StreamWriter sw = new StreamWriter(filepath, append: true))
            {
                foreach (var item in handler.AddList)
                {
                    sw.WriteLine(item);
                }


            }


        
    }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
