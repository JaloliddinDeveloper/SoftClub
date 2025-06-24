namespace Lesson_16.Classes
{
    internal class Circle : Shape
    {
        private double radius;
        private double Area;

        public Circle(double radius)
        {
            this.radius = radius;
            this.Area = 0;
        }

        public override double CalculateArea() =>
             this.Area=Math.PI * radius * radius;

        public override void PrintDescription() =>
          Console.WriteLine($"Bu aylana yuzasi: {this.Area}");
    }
}
