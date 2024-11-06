using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            handler.delete(student.StudentID);
        }
    }
}
