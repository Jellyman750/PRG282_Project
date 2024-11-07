using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class ViewAllStudents : Form
    {
        DataHandler handler = new DataHandler();
        private DataHandler dataHandler;
        public ViewAllStudents()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.DataSource = dataHandler.GetAllStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch data from the database using DataHandler
                DataTable studentsData = dataHandler.GetAllStudents();

                // Bind the data to the DataGridView
                dataGridView1.DataSource = studentsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ViewAllStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
