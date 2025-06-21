namespace Exam_2.ClassesTwo
{
    internal class BigDog : Dog
    {
        public BigDog(string name)
            : base(name)
        { }

        public override void Greet()
        {
            Console.WriteLine("Woooow");
        }

        public void Greet(Dog dog)
        {
            Console.WriteLine("Woooow");
        }

        public void Greet(BigDog bigdog)
        {
            Console.WriteLine("Woooow");
        }
    }
}
