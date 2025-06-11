using Lesson_6.Classes;

namespace PersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Firstname = "Jaloliddin";
            //person.Lastname = "Mahkamov";
            //person.Age = 30;
            //person.Address = "Toshkent Yunusobod";

            //string fullName = person.GetFullName();
            //Console.WriteLine($"Full Name: {fullName}");

            //int birthYear = person.GetBirthYear();
            //Console.WriteLine($"Birth Year: {birthYear}");


            //Task 2
            Rectangle rect = new Rectangle
            {
                Width = 5.0,
                Height = 3.0
            };


            double area1 = rect.GetArea();
            Console.WriteLine($"Initial dimensions: {rect.Width} × {rect.Height}");
            Console.WriteLine($"Area: {area1}");

            rect.Width = 10.0;
            rect.Height = 4.5;

            double area2 = rect.GetArea();
            Console.WriteLine($"\nUpdated dimensions: {rect.Width} × {rect.Height}");
            Console.WriteLine($"New area: {area2}");
        }
    }
}

