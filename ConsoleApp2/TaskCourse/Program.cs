namespace TaskCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            bool exit = false;
            Console.WriteLine("You have a course select one of this");
            Console.WriteLine("Add student:                       1");
            Console.WriteLine("Remove student:                    2");
            Console.WriteLine("Display all students:              3");
            Console.WriteLine("Search student:                    4");
            Console.WriteLine("Number of student:                 5");
            Console.WriteLine("Number of student above 18:        6");
            Console.WriteLine("Exit:                              7");
            while (!exit)
            {
                Console.WriteLine("select 7 to exit or 1,2,3,4,5,6 to do something");
                int choice;
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Menu.AddStudent(course);
                        break;

                    case 2:
                        Menu.RemoveStudent(course);
                        break;
                    case 3:
                        course.DisplayAllStudents();
                        break;
                    case 4:
                        Menu.SearchStudent(course);
                        break;
                    case 5:
                        course.GetStudentCount();
                        break;
                    case 6:
                        course.StudentAbove18Count();
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Select correct number");
                        break;
                }
            }
        }
    }
}
