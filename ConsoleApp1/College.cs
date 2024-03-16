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
            Console.WriteLine();
            Console.Write("Enter the id of the course: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the Name of the course: ");
            string name = Console.ReadLine();

            courses.Add(new Course(name, id));
        }

        public void AddDiscipline()
        {
            Console.WriteLine();
            bool selector = true;
            Console.Write("\nEnter the id of the course: ");
            int courseId = int.Parse(Console.ReadLine());

            Course course = courses.Find(l => l.Id == courseId);

            while (selector != false)
            {
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
            Console.WriteLine();
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
            Console.WriteLine();
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
                if (discipline == null)
                {
                    Console.WriteLine($"Could not find {disciplineId}");
                }
                Console.Write("Enter the id of the student: ");
                int studentId = int.Parse(Console.ReadLine());

                Student student = discipline.Students.Find(l => l.Id == studentId);

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter {i + 1}º grade: ");
                    float grade = float.Parse(Console.ReadLine());

                    student.AddGrades(grade);
                }
            }
        }

        public void ListCourses()
        {
            Console.WriteLine();
            Console.WriteLine("COURSES");
            foreach (Course course in courses)
            {
                Console.WriteLine(course.Name + " - ID: " + course.Id);
            }
        }

        public void ListDisciplines()
        {
            Console.WriteLine();

            Console.Write("\nEnter the id of the course: ");
            int courseId = int.Parse(Console.ReadLine());

            Course course = courses.Find(l => l.Id == courseId);
            if (course == null)
            {
                Console.WriteLine($"Could not find {courseId}");
            }
            else
            {
                Console.WriteLine("\nDISCIPLINES FROM COURSE - " + course.Id);
                foreach (Discipline discipline in course.Disciplines)
                {
                    Console.WriteLine(discipline.Name + " - ID: " + discipline.Id);
                }
            }
        }

        public void ListStudentsAverage()
        {
            Console.WriteLine();

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
                if (discipline == null)
                {
                    Console.WriteLine($"Could not find {disciplineId}");
                }
                else
                {
                    foreach (Student student in discipline.Students)
                    {
                        if (student.Grades.Count == 0)
                        {
                            Console.WriteLine(student.Name + " ID: " + student.Id + " GPA: no grades informed");
                        }
                        else
                        {
                            Console.WriteLine(student.Name + " ID: " + student.Id + " GPA: " + student.AverageGrade());
                        }
                    }
                }
            }
        }

        public void AverageClassScore()
        {
            Console.WriteLine();

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
                if (discipline == null)
                {
                    Console.WriteLine($"Could not find {disciplineId}");
                }
                else
                {
                    float averageGrade = default;

                    foreach (Student student in discipline.Students)
                    {
                        averageGrade += float.Parse(student.AverageGrade());
                    }

                    averageGrade /= discipline.Students.Count;

                    Console.WriteLine("Average grade of the class: " + averageGrade);
                }
            }
        }
    }
}
