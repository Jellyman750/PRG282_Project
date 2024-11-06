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
    public partial class Summary : Form
    {
        DataHandler handler = new DataHandler();
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            textBox1.Text = handler.calculateNumOfStudents().ToString();
            textBox2.Text = handler.calculateAvgOfAge().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
