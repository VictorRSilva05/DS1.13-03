using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class College
    {
        //Victor Rafael da Silva
        List<Course> courses = new List<Course>();

        public void RegisterCourse() // 1#
        {
            int id = default(int);
            Console.WriteLine();
            Console.Write("Enter the ID of the course: ");
            string auxId = Console.ReadLine();
            while (!int.TryParse(auxId, out id))
            {
                Console.WriteLine("ID must be only numbers: ");
                Console.Write("Enter the ID of the course: ");
                auxId = Console.ReadLine();
            }
            Console.Write("Enter the Name of the course: ");
            string name = Console.ReadLine();

            courses.Add(new Course(name, id));
        }

        public void AddDiscipline() // 2#
        {
            int courseId = default(int);
            Console.WriteLine();
            bool selector = true;
            Console.Write("Enter the ID of the course: ");
            string auxId = Console.ReadLine();
            while (!int.TryParse(auxId, out courseId))
            {
                Console.WriteLine("ID must be only numbers!");
                Console.Write("Enter the ID of the course: ");
                auxId = Console.ReadLine();
            }

            Course course = courses.Find(l => l.Id == courseId);

            while (selector != false)
            {
                if (course == null)
                {
                    Console.WriteLine($"Could not find {courseId}");
                }
                else
                {
                    int disciplineId = default(int);
                    Console.Write("Enter the ID of the discipline: ");
                    string auxDisciplineId = Console.ReadLine();
                    while (!int.TryParse(auxDisciplineId, out disciplineId))
                    {
                        Console.WriteLine("ID must be only numbers!");
                        Console.Write("Enter the ID of the course: ");
                        auxDisciplineId = Console.ReadLine();
                    }

                    Console.Write("Enter the name of the discipline: ");
                    string disciplineName = Console.ReadLine();

                    course.AddDiscipline(new Discipline(disciplineName, disciplineId, course.Name));

                    Console.Write("Do you want to add another discipline (true/false) ? ");
                    selector = bool.Parse(Console.ReadLine());
                }
            }
        }

        public void AddStudents() // 3#
        {
            int courseId = default(int);
            Console.WriteLine();
            bool selector = true;
            Console.Write("Enter the ID of the course: ");
            string auxId = Console.ReadLine();
            while (!int.TryParse(auxId, out courseId))
            {
                Console.Write("ID must be only numbers: ");
                Console.Write("Enter the ID of the course: ");
                auxId = Console.ReadLine();
            }

            Course course = courses.Find(l => l.Id == courseId);

            if (course == null)
            {
                Console.WriteLine($"Could not find {courseId}");
            }
            else
            {
                int disciplineId = default(int);
                Console.Write("Enter the ID of the discipline: ");
                string auxDisciplineId = Console.ReadLine();
                while (!int.TryParse(auxDisciplineId, out disciplineId))
                {
                    Console.WriteLine("ID must be only numbers!");
                    Console.Write("Enter the ID of the course: ");
                    auxDisciplineId = Console.ReadLine();
                }

                Discipline discipline = course.Disciplines.Find(l => l.Id == disciplineId);
                while (selector != false)
                {
                    int studentId = default(int);
                    Console.WriteLine("\nSTUDENT");
                    Console.Write("ID: ");
                    string auxStudentId = Console.ReadLine();
                    while (!int.TryParse(auxStudentId, out studentId))
                    {
                        Console.WriteLine("ID must be only numbers!");
                        Console.Write("Enter the ID of the course: ");
                        auxStudentId = Console.ReadLine();
                    }
                    Console.Write("Name: ");
                    string studentName = Console.ReadLine();

                    discipline.AddStudent(new Student(studentId, studentName));

                    Console.Write("Do you want to add another student (true/false) ? ");
                    selector = bool.Parse(Console.ReadLine());
                }
            }
        }

        public void AddGrades() // 4#
        {
            int courseId = default(int);
            Console.WriteLine();
            bool selector = true;

            Console.Write("Enter the ID of the course: ");
            string auxId = Console.ReadLine();
            while (!int.TryParse(auxId, out courseId))
            {
                Console.Write("ID must be only numbers: ");
                Console.Write("Enter the ID of the course: ");
                auxId = Console.ReadLine();
            }

            Course course = courses.Find(l => l.Id == courseId);

            if (course == null)
            {
                Console.WriteLine($"Could not find {courseId}");
            }
            else
            {
                int disciplineId = default(int);
                Console.Write("Enter the ID of the discipline: ");
                string auxDisciplineId = Console.ReadLine();
                while (!int.TryParse(auxDisciplineId, out disciplineId))
                {
                    Console.WriteLine("ID must be only numbers!");
                    Console.Write("Enter the ID of the course: ");
                    auxDisciplineId = Console.ReadLine();
                }

                Discipline discipline = course.Disciplines.Find(l => l.Id == disciplineId);
                if (discipline == null)
                {
                    Console.WriteLine($"Could not find {disciplineId}");
                }
                int studentId = default(int);
                Console.Write("Enter the id of the student: ");
                string auxStudentId = Console.ReadLine();
                while (!int.TryParse(auxStudentId, out studentId))
                {
                    Console.WriteLine("ID must be only numbers!");
                    Console.Write("Enter the ID of the course: ");
                    auxStudentId = Console.ReadLine();
                }

                Student student = discipline.Students.Find(l => l.Id == studentId);

                if (student == null)
                {
                    Console.WriteLine($"Could not find{studentId}");
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        float grade = default(float);
                        Console.Write($"Enter {i + 1}º grade: ");
                        string auxGrade = Console.ReadLine();
                        while (!float.TryParse(auxGrade, out grade))
                        {
                            Console.WriteLine("Grade must be a number!");
                            Console.Write($"Enter {i + 1}º grade: ");
                            auxGrade = Console.ReadLine();
                        }

                        student.AddGrades(grade);
                    }
                }
            }
        }

        public void ListCourses() // 5#
        {
            Console.WriteLine();
            Console.WriteLine("COURSES");
            if (courses.Count == 0)
            {
                Console.WriteLine("There are no registered courses yet!");
            }
            else
            {
                foreach (Course course in courses)
                {
                    Console.WriteLine(course.Name + " - ID: " + course.Id);
                }
            }
        }

        public void ListDisciplines() // 6#
        {
            int courseId = default(int);
            Console.WriteLine();

            Console.Write("Enter the ID of the course: ");
            string auxId = Console.ReadLine();
            while (!int.TryParse(auxId, out courseId))
            {
                Console.Write("ID must be only numbers: ");
                Console.Write("Enter the ID of the course: ");
                auxId = Console.ReadLine();
            }

            Course course = courses.Find(l => l.Id == courseId);
            if (course == null)
            {
                Console.WriteLine($"Could not find {courseId}");
            }
            else
            {
                if (course.Disciplines.Count == 0)
                {
                    Console.WriteLine("There are no registered disciplines for this course yet!");
                }
                else
                {
                    Console.WriteLine("\nDISCIPLINES FROM COURSE - " + course.Name);
                    foreach (Discipline discipline in course.Disciplines)
                    {
                        Console.WriteLine(discipline.Name + " - ID: " + discipline.Id);
                    }
                }
            }
        }

        public void ListStudentsAverage() // 7#
        {
            int courseId = default(int);
            Console.WriteLine();
            Console.Write("Enter the ID of the course: ");
            string auxId = Console.ReadLine();
            while (!int.TryParse(auxId, out courseId))
            {
                Console.Write("ID must be only numbers: ");
                Console.Write("Enter the ID of the course: ");
                auxId = Console.ReadLine();
            }

            Course course = courses.Find(l => l.Id == courseId);

            if (course == null)
            {
                Console.WriteLine($"Could not find {courseId}");
            }
            else
            {
                int disciplineId = default(int);
                Console.Write("Enter the ID of the discipline: ");
                string auxDisciplineId = Console.ReadLine();
                while (!int.TryParse(auxDisciplineId, out disciplineId))
                {
                    Console.WriteLine("ID must be only numbers!");
                    Console.Write("Enter the ID of the course: ");
                    auxDisciplineId = Console.ReadLine();
                }

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

        public void AverageClassScore() // 8#
        {
            int courseId = default(int);
            Console.WriteLine();

            Console.Write("Enter the ID of the course: ");
            string auxId = Console.ReadLine();
            while (!int.TryParse(auxId, out courseId))
            {
                Console.Write("ID must be only numbers: ");
                Console.Write("Enter the ID of the course: ");
                auxId = Console.ReadLine();
            }

            Course course = courses.Find(l => l.Id == courseId);

            if (course == null)
            {
                Console.WriteLine($"Could not find {courseId}");
            }
            else
            {
                int disciplineId = default(int);
                Console.Write("Enter the ID of the discipline: ");
                string auxDisciplineId = Console.ReadLine();
                while (!int.TryParse(auxDisciplineId, out disciplineId))
                {
                    Console.WriteLine("ID must be only numbers!");
                    Console.Write("Enter the ID of the course: ");
                    auxDisciplineId = Console.ReadLine();
                }

                Discipline discipline = course.Disciplines.Find(l => l.Id == disciplineId);
                if (discipline == null)
                {
                    Console.WriteLine($"Could not find {disciplineId}");
                }
                else
                {
                    if (discipline.Students.Count == 0)
                    {
                        Console.WriteLine("There are no students in this discipline yet!");
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
}
