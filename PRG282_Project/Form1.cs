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
    public partial class Form1 : Form
    {
        Update update = new Update();
        Summary summary = new Summary();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdateStudent_Click(object sender, EventArgs e)
        {
            update.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();
            delete.Show();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtStudentAge.Clear();
            txtCourse.Clear();
        }

        private void BtnSummary_Click(object sender, EventArgs e)
        {
            summary.Show();
        }
    }
}
