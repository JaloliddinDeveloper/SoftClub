namespace HomeWork_12.ClassesTwo
{
    internal class CargoCar: Transport
    {
        public int LoadCapacity { get; set; }

        public CargoCar(string name, int speed, int capacity, int loadCapacity)
            : base(name, speed, capacity)
        {
            LoadCapacity = loadCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cargo Car with {LoadCapacity} kg load capacity");
        }
    }
}
