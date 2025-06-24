namespace Lesson_16.ClassesTwo
{
    internal class Bus:IMovable
    {
        private string color;
        private double speed;
        private string model;
        public Bus(string color, double speed, string model)
        {
            this.model = model;
            this.color = color;
            this.speed = speed;
        }

        public string MoveLeft(string move)
        {
            return $"Bus move {move}";
        }

        public string MoveRight(string move)
        {
            return $"Bus move {move}";
        }
    }
}
