namespace Lesson_16.Classes
{
    internal abstract class Shape
    {
        public abstract double CalculateArea();

        public virtual void PrintDescription()
        {
            Console.WriteLine("");
        }
    }
}
