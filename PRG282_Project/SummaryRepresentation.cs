using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    internal class SummaryRepresentation
    {
        
       public SummaryRepresentation()
        {

        }
        int totalNumberStudents, AvgAge;

        public SummaryRepresentation(int totalNumberStudents, int avgAge)
        {
            this.totalNumberStudents = totalNumberStudents;
            AvgAge = avgAge;
        }

        public int TotalNumberStudents { get => totalNumberStudents; set => totalNumberStudents = value; }
        public int AvgAge1 { get => AvgAge; set => AvgAge = value; }


        public override string ToString()
        {
            return $"=================\nTotal Number of students{TotalNumberStudents}\n=================\n\n=================\nAvarage Overall Age:{AvgAge1}\n=================";
        }
    }
}
