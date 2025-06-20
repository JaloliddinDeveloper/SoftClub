using System;

namespace Homework_13.Classes
{
    internal class Student:Person
    {
        public Student(string name) : base(name) { }

        public void Study()
        {
            Console.WriteLine($"{Name}: The student is studying.");
        }
    }
}
