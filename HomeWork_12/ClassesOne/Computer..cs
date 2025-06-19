﻿namespace HomeWork_12.ClassesOne
{
    internal class Computer
    {
        protected string brand;
        protected string processor;
        protected int ram;

        public Computer(string brand, string processor, int ram)
        {
            this.brand = brand;
            this.processor = processor;
            this.ram = ram;
        }

        public void Start()
        {
            Console.WriteLine($"{brand} computer is starting...");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Processor: {processor}, RAM: {ram} GB");
        }
    }
}
