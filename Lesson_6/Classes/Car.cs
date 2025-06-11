namespace Lesson_6.Classes
{
    internal class Car
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public double Mileage { get; private set; }
        public double Fuel { get; private set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = 0;
            Fuel = 0;
        }

        public void Drive(double miles)
        {
            if (miles <= 0)
            {
                Console.WriteLine("Please enter a positive number of miles to drive.");
                return;
            }

            if (Fuel < miles)
            {
                Console.WriteLine($"Insufficient fuel to drive {miles} miles. Please refuel.");
            }
            else
            {
                Fuel -= miles;
                Mileage += miles;
                Console.WriteLine($"Drove {miles} miles. Remaining fuel: {Fuel:F1} gallons. Total mileage: {Mileage:F1} miles.");
            }
        }

        public void AddFuel(double gallons)
        {
            if (gallons <= 0)
            {
                Console.WriteLine("Please enter a positive amount of fuel to add.");
                return;
            }
            Fuel += gallons;
            Console.WriteLine($"Added {gallons:F1} gallons. Current fuel level: {Fuel:F1} gallons.");
        }
    }
}

