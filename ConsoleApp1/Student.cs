using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        //Victor Rafael da Silva
        public int Id { get; set; }
        public string Name { get; set; }
        public List<float> Grades { get ;set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Grades = new List<float>();
        }

        public void AddGrades(float grade)
        {
            Grades.Add(grade);
        }

        public string AverageGrade()
        {
            return Grades.Average().ToString("F1");
        }
    }
}
