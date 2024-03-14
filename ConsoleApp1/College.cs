using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class College
    {
        List<Course> courses = new List<Course>();

        public void RegisterCourse()
        {
            Console.Write("Enter the id of the course: ");
            string id = Console.ReadLine();
            Console.Write("Enter the Name of the course: ");
            string name = Console.ReadLine();

            courses.Add(new Course(id, name));
        }

        public void AddDiscipline()
        {
            bool selector = true;

            while (selector != false)
            {
                Console.WriteLine("\nAdd a discipline for the course: ");
                Console.Write("ID: ");
                string courseId = Console.ReadLine();
                Console.Write("Name: ");
                string courseName = Console.ReadLine();

                Console.Write("Do you want to add another course (true/false) ? ");
                selector = bool.Parse(Console.ReadLine());
            }
        }
    }
}
