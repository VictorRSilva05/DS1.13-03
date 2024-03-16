namespace ConsoleApp1
{
    internal class Program
    {
        Program()
        {
            //Victor Rafael da Silva
            College college = new College();

            string input;
            byte selector = default;

            while (selector != 9)
            {
                Console.WriteLine();
                Console.WriteLine("1- Register a course");
                Console.WriteLine("2- Register the disciplines of the course");
                Console.WriteLine("3- Add students to a discipline");
                Console.WriteLine("4- Add grades to a student in a discipline");
                Console.WriteLine("5- List all courses");
                Console.WriteLine("6- List all disciplines from a course");
                Console.WriteLine("7- List all students of the discipline and their average");
                Console.WriteLine("8- Average score of the class");
                Console.WriteLine("9- Exit");
                Console.Write("\nOption: ");
                input = Console.ReadLine();
                while (!byte.TryParse(input, out selector))
                {
                    Console.Write("Invalid input, try again: ");
                    input = Console.ReadLine();
                }
                switch (selector)
                {
                    case 1:
                        college.RegisterCourse();
                        break;
                    case 2:
                        college.AddDiscipline();
                        break;
                    case 3:
                        college.AddStudents();
                        break;
                    case 4:
                        college.AddGrades();
                        break;
                    case 5:
                        college.ListCourses();
                        break;
                    case 6:
                        college.ListDisciplines();
                        break;
                    case 7:
                        college.ListStudentsAverage();
                        break;
                    case 8:
                        college.AverageClassScore();
                        break;
                    case 9:
                        Console.WriteLine("\nBye ;-;");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }
        }

        static void Main(string[] args)
        {
            _ = new Program();
        }
    }
}
