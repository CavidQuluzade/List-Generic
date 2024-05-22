using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCourse
{
    internal static class Menu
    {
        public static void AddStudent(Course course)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Student added");
            Student newStudent = new Student(name, surname, pin, age);
            course.AddStudent(newStudent);
        }
        public static void RemoveStudent(Course course)
        {
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();
            course.RemoveStudent(pin);
        }
        public static void SearchStudent(Course course)
        {
            Console.Write("Enter PIN: ");
            string pin = Console.ReadLine();
            course.SearchStudent(pin);
        }
    }
}
