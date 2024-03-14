using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Course
    {
        public string Name { get; set; }
        public string Id { get; set; }
        List<Discipline> Disciplines { get; set; }

        public Course(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public void AddDiscipline(Discipline discipline)
        {
            Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            Disciplines.Remove(discipline);
        }
    }
}
