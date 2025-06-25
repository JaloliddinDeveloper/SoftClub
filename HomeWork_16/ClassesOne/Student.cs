namespace HomeWork_16.ClassesOne
{
    internal class Student : Person
    {
        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Study() =>
            Console.WriteLine("I'm studying");

        public void ShowAge()=>
            Console.WriteLine(this.Age);
    }
}
