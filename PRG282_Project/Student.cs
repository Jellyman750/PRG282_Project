using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    internal class Student
    {
        int studentID, age;
        string name, course;

        public Student()
        {
        }
        public Student(int studentID, string name, int age, string course)
        {
            this.studentID = studentID;
            this.name = name;
            this.age = age;
            this.course = course;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }
    }
}
