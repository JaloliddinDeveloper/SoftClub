namespace HomeWork_12.ClassesTwo
{
    internal class PassengerPlane: Transport
    {
        public int FlightRange { get; set; }

        public PassengerPlane(string name, int speed, int capacity, int flightRange)
            : base(name, speed, capacity)
        {
            FlightRange = flightRange;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Passenger Plane with {FlightRange} km flight range");
        }
    }
}
