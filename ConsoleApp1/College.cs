using System;
using System.Collections.Generic;
using System.Linq;
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
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the Name of the course: ");
            string name = Console.ReadLine();

            courses.Add(new Course(name, id));
        }

        public void AddDiscipline()
        {
            bool selector = true;

            while (selector != false)
            {
                Console.Write("\nEnter the id of the course: ");
                int courseId = int.Parse(Console.ReadLine());

                Course course = courses.Find(l => l.Id == courseId);
                if (course == null)
                {
                    Console.WriteLine($"Could not find {courseId}");
                }
                else
                {
                    Console.Write("Enter the id of the discipline: ");
                    int disciplineId = int.Parse(Console.ReadLine());
                    Console.Write("Enter the name of the discipline: ");
                    string disciplineName = Console.ReadLine();

                    course.AddDiscipline(new Discipline(disciplineName, disciplineId));


                    Console.Write("Do you want to add another discipline (true/false) ? ");
                    selector = bool.Parse(Console.ReadLine());
                }
            }
        }

        public void AddStudents()
        {
            bool selector = true;

            Console.Write("Enter the id of the course: ");
            int courseId = int.Parse(Console.ReadLine());

            Course course = courses.Find(l => l.Id == courseId);

            if (course == null)
            {
                Console.WriteLine($"Could not find {courseId}");
            }
            else
            {
                Console.Write("Enter the id of the discipline: ");
                int disciplineId = int.Parse(Console.ReadLine());

                Discipline discipline = course.Disciplines.Find(l => l.Id == disciplineId);
                while (selector != false)
                {
                    Console.WriteLine("\nSTUDENT");
                    Console.Write("ID: ");
                    int studentId = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string studentName = Console.ReadLine();

                    discipline.AddStudent(new Student(studentId, studentName));

                    Console.Write("Do you want to add another student (true/false) ? ");
                    selector = bool.Parse(Console.ReadLine());
                }
            }
        }

        public void AddGrades()
        {
            bool selector = true;

            Console.Write("Enter the id of the course: ");
            int courseId = int.Parse(Console.ReadLine());

            Course course = courses.Find(l => l.Id == courseId);

            if (course == null)
            {
                Console.WriteLine($"Could not find {courseId}");
            }
            else
            {
                Console.Write("Enter the id of the discipline: ");
                int disciplineId = int.Parse(Console.ReadLine());

                Discipline discipline = course.Disciplines.Find(l => l.Id == disciplineId);
                if(discipline == null)
                {
                    Console.WriteLine($"Could not find {disciplineId}");
                }
                Console.Write("Enter the id of the student: ");
                int studentId = int.Parse (Console.ReadLine());

                Student student = discipline.Students.Find(l => l.Id == studentId);

                for(int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter {i+1}º grade: ");
                    float grade = float.Parse(Console.ReadLine());

                    student.AddGrades(grade);
                }
            }
        }
    }
}
