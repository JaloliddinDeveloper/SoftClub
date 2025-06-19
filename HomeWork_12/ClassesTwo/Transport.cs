namespace HomeWork_12.ClassesTwo
{
    internal class Transport
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public Transport(string name, int speed, int capacity)
        {
            Name = name;
            Speed = speed;
            Capacity = capacity;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Transport: {Name}, Speed: {Speed} km/h, Capacity: {Capacity}");
        }
    }
}
