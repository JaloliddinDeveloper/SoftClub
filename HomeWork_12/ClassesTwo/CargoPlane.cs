namespace HomeWork_12.ClassesTwo
{
    internal class CargoPlane: Transport
    {
        public int MaxCargoWeight { get; set; }

        public CargoPlane(string name, int speed, int capacity, int maxCargoWeight)
            : base(name, speed, capacity)
        {
            MaxCargoWeight = maxCargoWeight;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cargo Plane with {MaxCargoWeight} kg max cargo weight");
        }
    }
}
