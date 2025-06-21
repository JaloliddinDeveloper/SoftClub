namespace Exam_2.ClassesTwo
{
    internal abstract class Animal
    {
        private string name;

        protected Animal(string name)
        {
            this.name = name;   
        }

        public abstract void Greet();
    }
}
