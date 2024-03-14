using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Discipline
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public List<Student> Students { get; set; }

        public Discipline(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
    }
}
