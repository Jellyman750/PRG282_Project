using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace PRG282_Project
{
    public partial class Update : Form
    {
        SqlConnection conn = new SqlConnection("Server=.; Initial Catalog=PRG282_Project; Integrated Security=true");

        DataHandler dh = new DataHandler();
        Student student = new Student();

        
        public Update()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            student.StudentID = int.Parse((textBox1.Text));
            student.Name = (textBox2.Text);
            student.Age = int.Parse((textBox3.Text));
            student.Course = textBox4.Text;

            dh.update(student.StudentID, student.Name, student.Age, student.Course);

            string filepath = "Update.txt";
            dh.UpdateList.Add(new Student(student.StudentID, student.Name, student.Age, student.Course));


            using (StreamWriter sw = new StreamWriter(filepath, append: true))
            {
                    foreach (var item in dh.UpdateList)
                    {
                        sw.WriteLine(item);
                    }


             }
           





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            string queryStudents = @"SELECT * FROM Students";

            SqlDataAdapter studentAdapter = new SqlDataAdapter(queryStudents, conn);

            DataSet ds = new DataSet();

            studentAdapter.Fill(ds, "Students");

            dataGridView1.DataSource = ds.Tables[0];
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }
    }
}
