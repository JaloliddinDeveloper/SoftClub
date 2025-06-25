namespace HomeWork_16.ClassesTwo
{
    internal class Rectangle : Shape
    {
        private double with;
        private double length;

        public Rectangle(double with, double length, string color)
            : base(color)
        {
            this.with = with;
            this.length = length;
        }

        public double Area()
        {
            return this.with * this.length;
        }

        public double Peremetr()
        {
            return this.with + this.length;
        }
    }
}
