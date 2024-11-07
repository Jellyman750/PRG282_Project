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
        string[] arrUpdate;
        public List<DisplayFinalSummaryData> newUpdateList = new List<DisplayFinalSummaryData>();
        
        public List<Student>DeleteList= new List<Student>();
        string[] arrDelete;
        public List<DisplayFinalSummaryData> newDeleteList = new List<DisplayFinalSummaryData>();


        public List<Student> AddList = new List<Student>();
        string[] arrAdd;
        public List<DisplayFinalSummaryData> newAddList = new List<DisplayFinalSummaryData>();

       
        public List<SummaryRepresentation> SummaryList = new List<SummaryRepresentation>();

        public List<DisplayFinalSummaryData> DatabaseList = new List<DisplayFinalSummaryData>();
        

        

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

                
                //UpdateList.Add(new Student(id, name, age,course));

                
                
                

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void delete(int id, string name, int age, string course)
        {
            try
            {
                string query = $@"DELETE FROM Students WHERE Student_ID = '{id}' AND Student_Name = '{name}' AND Student_Age = '{age}' AND Course = '{course}'";
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
        public void AddStudent(string studentID,string name, int age, string course)
        {
            using (SqlConnection conn = new SqlConnection("Server=.; Initial Catalog=PRG282_Project; Integrated Security=true"))
            {

                string query = $@"Insert Into  Students Values ('{studentID}','{name}' , '{age}' ,'{course}')";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

         

               
            
            }
        }

        public DataTable GetAllStudents()
        {
            using (SqlConnection conn = new SqlConnection("Server=.; Initial Catalog=PRG282_Project; Integrated Security=true"))
            {
                string query = "SELECT * FROM Students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void AddSummaryUpdate()
        {

            string filepath1 = "Update.txt";
            using (StreamReader sr = new StreamReader(filepath1))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    // Split the line into an array of strings
                    string[] arrUpdate = line.Split(',');

                    // Ensure arrUpdate has the expected number of elements to avoid errors
                    if (arrUpdate.Length >= 4)
                    {
                        // Parse values and add a new DisplayFinalSummaryData object to newUpdateList
                        newUpdateList.Add(new DisplayFinalSummaryData(int.Parse(arrUpdate[0]),  arrUpdate[1], int.Parse(arrUpdate[2]), arrUpdate[3]));
                    }
                }

            }

         
        }
        public void AddSummaryDelete()
        {
            string filepath1 = "Delete.txt";
            using (StreamReader sr = new StreamReader(filepath1))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    // Split the line into an array of strings
                    string[] arrDelete = line.Split(',');

                    // Ensure arrUpdate has the expected number of elements to avoid errors
                    if (arrDelete.Length >= 4)
                    {
                        // Parse values and add a new DisplayFinalSummaryData object to newUpdateList
                        newDeleteList.Add(new DisplayFinalSummaryData(int.Parse(arrDelete[0]), arrDelete[1], int.Parse(arrDelete[2]), arrDelete[3]));
                    }
                }

            }
        }

        public void AddSummaryInsert()
        {
            string filepath1 = "AddedStudents.txt";
            using (StreamReader sr = new StreamReader(filepath1))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    // Split the line into an array of strings
                    string[] arrAdd = line.Split(',');

                    // Ensure arrUpdate has the expected number of elements to avoid errors
                    if (arrAdd.Length >= 4)
                    {
                        // Parse values and add a new DisplayFinalSummaryData object to newUpdateList
                       newAddList.Add(new DisplayFinalSummaryData(int.Parse(arrAdd[0]), arrAdd[1], int.Parse(arrAdd[2]), arrAdd[3]));
                    }
                }

            }
        }

        public void  DisplayNewDatabase()
        {
            
            try
            { 
                string Command = @"Select * from Students";

                cmd = new SqlCommand(Command, conn);
                conn.Open();
               
               
                SqlCommand cmd1 = new SqlCommand(Command, conn);
                SqlDataReader reader = cmd1.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        DatabaseList.Add(new DisplayFinalSummaryData(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3)));
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Categories has no Rows");
                }
                reader.Close();
                conn.Close();


            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}

