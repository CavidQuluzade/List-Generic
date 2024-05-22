using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCourse
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PIN { get; set; }
        public int Age { get; set; }
        public Student(string name, string surname, string pin, int age)
        {
            Name = name;
            Surname = surname;
            PIN = pin;
            Age = age;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Surname}, PIN: {PIN},AGE: {Age}");
        }
    }
}
