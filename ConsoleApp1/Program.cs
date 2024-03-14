namespace ConsoleApp1
{
    internal class Program
    {
        Program()
        {
            College college = new College();

            byte selector = default;

            while (selector != 7)
            {
                Console.Clear();
                Console.WriteLine("1- Register a course");
                Console.WriteLine("2- Register the disciplines of the course");
                Console.WriteLine("3- Add students to a course");
                Console.WriteLine("4- Add grades to a student in a discipline");
                Console.WriteLine("5- List all students of the discipline and their average");
                Console.WriteLine("6- Average score of the class");
                Console.WriteLine("7- Exit");
                Console.Write("\nOption: ");
                selector = byte.Parse(Console.ReadLine());

                switch (selector)
                {
                    case 1:
                        college.RegisterCourse();
                        break;
                    case 2:
                        college.AddDiscipline();
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
