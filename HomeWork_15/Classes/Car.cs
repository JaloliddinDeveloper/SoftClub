namespace HomeWork_15.Classes
{
    internal class Car
    {
        private decimal gasoline;

        public Car(int initialGasoline)
        {
            gasoline = initialGasoline;
        }

        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("No gasoline");
            }
        }

        public bool Refuel(decimal amount)
        {
            gasoline += amount;
            return true;
        }
    }
}
