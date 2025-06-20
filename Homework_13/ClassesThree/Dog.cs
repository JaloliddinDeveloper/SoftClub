using System;

namespace Homework_13.ClassesThree
{
    internal class Dog : AnimalApp
    {
        public override void Eat()
        {
            Console.WriteLine($"{GetName()} is eating.");
        }
    }
}
