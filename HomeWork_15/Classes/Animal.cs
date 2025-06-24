namespace HomeWork_15.Classes
{
    internal abstract class Animal
    {
        protected string Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }
}
