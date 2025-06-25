namespace HomeWork_16.ClassesOne
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public void Greet() =>
            Console.WriteLine("Hello");

        public void SetAge(int age) =>
            this.Age = age;
    }
}
