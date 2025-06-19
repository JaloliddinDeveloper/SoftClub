namespace HomeWork_12.ClassesTwo
{
    internal class PassengerCar: Transport
    {
        public int NumberOfSeats { get; set; }

        public PassengerCar(string name, int speed, int capacity, int numberOfSeats)
            : base(name, speed, capacity)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Passenger Car with {NumberOfSeats} seats");
        }
    }
}
