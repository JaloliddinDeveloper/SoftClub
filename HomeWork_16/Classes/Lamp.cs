namespace HomeWork_16.Classes
{
    internal class Lamp : IDevice
    {
        public bool IsOn { get; private set; }
        public int Brightness { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("💡 Lamp is turned ON.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("💡 Lamp is turned OFF.");
        }

        public void SetBrightness(int level)
        {
            if (level < 0 || level > 100)
                Console.WriteLine("⚠️ Brightness must be between 0 and 100.");
            else
            {
                Brightness = level;
                Console.WriteLine($"💡 Lamp brightness set to {Brightness}%.");
            }
        }
    }
}
