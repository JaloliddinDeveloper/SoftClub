namespace HomeWork_12.ClassesTwo
{
    internal class Train : Transport
    {
        public int NumberOfWagons { get; set; }

        public Train(string name, int speed, int capacity, int numberOfWagons)
            : base(name, speed, capacity)
        {
            NumberOfWagons = numberOfWagons;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Train with {NumberOfWagons} wagons");
        }
    }
}
