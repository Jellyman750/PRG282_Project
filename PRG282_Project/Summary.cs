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
    public partial class Summary : Form
    {
        DataHandler handler = new DataHandler();
        SummaryRepresentation sr = new SummaryRepresentation();
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

        private void btnDisplaySummary_Click(object sender, EventArgs e)
        {
            sr.TotalNumberStudents = int.Parse(textBox1.Text);
            sr.AvgAge1= int.Parse(textBox1.Text);
            string filepath = "Delete.txt";
            handler.SummaryList.Add(new SummaryRepresentation(sr.TotalNumberStudents,sr.AvgAge1));


            using (StreamWriter sw = new StreamWriter(filepath, append: true))
            {
                foreach (var item in handler.SummaryList)
                {
                    sw.WriteLine(item);
                }


            }
        }
    }
    }
}
