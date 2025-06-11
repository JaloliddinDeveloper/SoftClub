using Lesson_6.Classes;

namespace PersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "Jaloliddin";
            person.Lastname = "Mahkamov";
            person.Age = 30;
            person.Address = "Toshkent Yunusobod";

            string fullName = person.GetFullName();
            Console.WriteLine($"Full Name: {fullName}");

            int birthYear = person.GetBirthYear();
            Console.WriteLine($"Birth Year: {birthYear}");
        }
    }
}
