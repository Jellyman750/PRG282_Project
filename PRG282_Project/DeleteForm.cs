using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG282_Project
{
    public partial class DeleteForm : Form
    {
        DataHandler handler = new DataHandler();
        Student student = new Student();

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student.StudentID = int.Parse(textBox1.Text);
           
            handler.delete(student.StudentID);//We have to delete the row,and not just delete the ID from the Database,Kyk of of datagridviewRow kan gebruiik
            string filepath = "Delete.txt";
            handler.DeleteList.Add(new Student(student.StudentID, student.Name, student.Age, student.Course));


            using (StreamWriter sw = new StreamWriter(filepath, append: true))
            {
                foreach (var item in handler.DeleteList)
                {
                    sw.WriteLine(item);
                }


            }
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
