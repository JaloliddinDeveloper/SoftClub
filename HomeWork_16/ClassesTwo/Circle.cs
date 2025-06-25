namespace HomeWork_16.ClassesTwo
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double radius, string color)
            : base(color)
        {
            this.radius = radius;
        }

        public double Area() =>
             Math.PI * radius * radius;

        public double Peremetr() =>
            2 * Math.PI * radius;
    }
}
