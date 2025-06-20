﻿namespace Homework_13.ClassesThree
{
    internal abstract class AnimalApp
    {
        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }
}
