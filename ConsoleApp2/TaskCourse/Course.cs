using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TaskCourse
{
    internal class Course
    {
        private List<Student> students;
        public Course() 
        {
            students = new List<Student>();   
        }
        public void AddStudent(Student newstudent)
        {
            if (students.Any(student => student.PIN == newstudent.PIN))
            {
                Console.WriteLine("A student with the same PIN already exists.");
                return;
            }
            else
            {
                students.Add(newstudent);
            }
            
        }
        
        public void RemoveStudent(string pin)
        {
            Repeat:
            var studentToRemove = students.FirstOrDefault(student => student.PIN == pin);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student removed");
            }
            else
            {
                Console.WriteLine("Not found");
                Console.WriteLine("If you want enter pin again use '+' else use '-'");
                string choice = Console.ReadLine();
                if (choice == "+")
                {
                    goto Repeat;
                }
                else
                {
                    Console.WriteLine("NO student was removed");
                }
            }
        }
        public void DisplayAllStudents()
        {
            foreach (var student in students)
            {
                student.GetDetails();
            }
        }
        public void SearchStudent(string pin)
        {
            Repeat1:
            var student = students.FirstOrDefault(student => student.PIN == pin);
            if (student != null)
            {
                Console.WriteLine($"{student.Name} {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
            }
            else
            {
                Console.WriteLine("Student not found. Try again? use '+'");
                string choi = Console.ReadLine();
                if( choi == "+")
                {
                    goto Repeat1;
                }
                else
                {
                    Console.WriteLine("You don't found student");
                }
            }
        }
        public void GetStudentCount()
        {
            Console.WriteLine(students.Count);
        }
        public void StudentAbove18Count()
        {
            int count = 0;
            foreach (var student in students)
            {
                if (student.Age > 18)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of students above 18 is "+count);
        }
    }
}
