namespace Lesson_16.ClassesTwo
{
    internal class Car: IMovable
    {
        private string color;
        private double speed;
        private string model;
        public Car(string color, double speed, string model)
        {
            this.model = model;
            this.color = color;
            this.speed = speed;
        }

        public string MoveLeft(string move)
        {
            return $"Car move {move}";
        }

        public string MoveRight(string move)
        {
            return $"Car move {move}";
        }
    }
}
