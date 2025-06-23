namespace Exam_2.ClassesTwo
{
    internal class Cat : Animal
    {

        public Cat(string name)
            : base(name)
        { }

        public override void Greet()
        {
            Console.WriteLine("Meow");
        }
    }
}
