﻿namespace HomeWork_12.ClassesOne
{
    internal class SmartPhone:Computer
    {
        private int cameraResolution;

        public SmartPhone(string brand, string processor, int ram, int cameraResolution)
            : base(brand, processor, ram)
        {
            this.cameraResolution = cameraResolution;
        }

        public void TakePhoto()
        {
            Console.WriteLine($"{brand} smartphone took a photo with {cameraResolution}MP camera");
        }
    }
}
