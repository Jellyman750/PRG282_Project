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
using System.Data.SqlClient;

namespace PRG282_Project
{
    public partial class DeleteForm : Form
    {
        SqlConnection conn = new SqlConnection("Server=JANNIE\\SQLEXPRESS; Initial Catalog=PRG282_Project; Integrated Security=true");

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
            student.StudentID = int.Parse((textBox1.Text));
            student.Name = (textBox2.Text);
            student.Age = int.Parse((textBox3.Text));
            student.Course = textBox4.Text;

            handler.delete(student.StudentID, student.Name, student.Age, student.Course);//We have to delete the row,and not just delete the ID from the Database,Kyk of of datagridviewRow kan gebruiik
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
            string queryStudents = @"SELECT * FROM Students";

            SqlDataAdapter studentAdapter = new SqlDataAdapter(queryStudents, conn);

            DataSet ds = new DataSet();

            studentAdapter.Fill(ds, "Students");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
