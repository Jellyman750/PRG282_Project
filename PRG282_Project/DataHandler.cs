using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PRG282_Project
{
    internal class DataHandler
    {
        SqlConnection conn = new SqlConnection("Server=.; Initial Catalog=PRG282_Project; Integrated Security=true");

        SqlCommand cmd;
        SqlDataAdapter adapter;
        public List<Student> UpdateList= new List<Student>();
        public List<Student>DeleteList= new List<Student>();
        public List<SummaryRepresentation> SummaryList = new List<SummaryRepresentation>();

        public void update(int id, string name, int age, string course)
        {
            try
            {
              
                string query = $@"UPDATE Students SET Student_Name = '{name}', Student_Age = '{age}', Course = '{course}' WHERE Student_ID = '{id}'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Records Updated");
                conn.Close();

                
                
                

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void delete(int id)
        {
            try
            {
                string query = $@"DELETE FROM Students WHERE Student_ID = '{id}'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Records Deleted");
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public int calculateNumOfStudents()
        {
            int count = 0;
            
             string query = "SELECT COUNT(*) FROM Students";
             cmd = new SqlCommand(query, conn);
             conn.Open();
             count = (int)cmd.ExecuteScalar();
             conn.Close();
            
            return count;
        }

        public int calculateAvgOfAge()
        {
            int count = 0;

            string query = "SELECT AVG(Student_Age) FROM Students";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            count = (int)cmd.ExecuteScalar();
            conn.Close();

            return count;
        }
    }
}
