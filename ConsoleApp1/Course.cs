using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Course
    {
        //Victor Rafael da Silva
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Discipline> Disciplines { get; set; }

        public Course() { }
        public Course(string name, int id)
        {
            Name = name;
            Id = id;
            Disciplines = new List<Discipline>();
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
