﻿namespace Lesson_6.Classes
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
