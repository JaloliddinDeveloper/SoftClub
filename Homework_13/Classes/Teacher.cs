using System;

namespace Homework_13.Classes
{
    internal class Teacher:Person
    {
        public Teacher(string name) : base(name) { }

        public void Explain()
        {
            Console.WriteLine($"{Name}: The teacher is explaining.");
        }
    }
}
