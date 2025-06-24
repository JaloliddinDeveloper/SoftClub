namespace Lesson_16.Classes
{
    internal class Rectangle : Shape
    {
        private double a;
        private double b;
        private double Area;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.Area = 0;
        }

        public override double CalculateArea() =>
             this.Area=a * b;

        public override void PrintDescription() =>
            Console.WriteLine($"Bu to'rt burchak {this.Area}");
    }
}
