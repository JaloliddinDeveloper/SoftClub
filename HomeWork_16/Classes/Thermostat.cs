namespace HomeWork_16.Classes
{
    internal class Thermostat:IDevice
    {
        public bool IsOn { get; private set; }
        public double Temperature { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("🌡️ Thermostat is turned ON.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("🌡️ Thermostat is turned OFF.");
        }

        public void SetTemperature(double temp)
        {
            Temperature = temp;
            Console.WriteLine($"🌡️ Thermostat temperature set to {Temperature}°C.");
        }
    }
}
