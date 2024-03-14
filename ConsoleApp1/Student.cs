using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<float> Grades { get ;set; }

        public Student(int id, string name, List<float> grades)
        {
            Id = id;
            Name = name;
            Grades = grades;
        }
    }
}
