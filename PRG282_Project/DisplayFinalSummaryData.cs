using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    internal class DisplayFinalSummaryData
    {
        int studentID, Age;
        string Name, course;

        public DisplayFinalSummaryData(int studentID, string name,int age, string course)
        {
            this.studentID = studentID;
            Age = age;
            Name = name;
            this.course = course;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public int Age1 { get => Age; set => Age = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Course { get => course; set => course = value; }

        public override string ToString()
        {
            return $" =================\nStudent ID: {studentID},Student Name: {Name},Student Age: {Age},Course: {course}\n================= ";
        }
    }
}
