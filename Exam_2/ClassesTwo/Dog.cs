namespace Exam_2.ClassesTwo
{
    internal class Dog : Animal
    {
        public Dog(string name)
            : base(name)
        { }

        public override void Greet()
        {
            Console.WriteLine("Woof");
        }

        public void Greet(Dog dog)
        {
            Console.WriteLine("Wooof");
        }
    }
}
