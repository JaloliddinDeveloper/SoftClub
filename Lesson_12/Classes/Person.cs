namespace Lesson_12.Classes
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }    

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age; 
        }

        public void GetInfo()
        {
            Console.WriteLine($"Person name: {this.Name} Age: {Age}");
        }
    }
}
