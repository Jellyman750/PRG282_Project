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
        private DataHandler dataHandler;
        public ViewAllStudents(DataHandler dataHandler)
        {
            InitializeComponent();
            dataHandler = handler;
            LoadStudentData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1_CellContentClick.DataSource = dataHandler.GetAllStudents();
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
                dataGridView1_CellContentClick.DataSource = studentsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
