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
            //Rectangle rect = new Rectangle
            //{
            //    Width = 5.0,
            //    Height = 3.0
            //};


            //double area1 = rect.GetArea();
            //Console.WriteLine($"Initial dimensions: {rect.Width} × {rect.Height}");
            //Console.WriteLine($"Area: {area1}");

            //rect.Width = 10.0;
            //rect.Height = 4.5;

            //double area2 = rect.GetArea();
            //Console.WriteLine($"\nUpdated dimensions: {rect.Width} × {rect.Height}");
            //Console.WriteLine($"New area: {area2}");

            //Task 3    

            //Student[] students = new Student[]
            //{
            //    new Student { Name = "Alice",   GradeLevel = 9,  Scores = new int[] { 92, 87, 85, 90 } },
            //    new Student { Name = "Bob",     GradeLevel = 11, Scores = new int[] { 68, 72, 70, 65 } },
            //    new Student { Name = "Catherine",GradeLevel = 10, Scores = new int[] { 78, 82, 80, 75 } },
            //    new Student { Name = "Daniel",  GradeLevel = 8,  Scores = new int[] { 88, 90, 85, 92 } },
            //    new Student { Name = "Emma",    GradeLevel = 12, Scores = new int[] { 60, 55, 58, 62 } }
            //};

            //foreach (var student in students)
            //{
            //    double avg = student.GetAverage();
            //    Console.WriteLine($"Student: {student.Name} (Grade {student.GradeLevel})");
            //    Console.WriteLine($"Average Score: {avg:F1}");

            //    if (avg > 85)
            //    {
            //        Console.WriteLine("🌟 Excellent work! Keep it up!");
            //    }
            //    else if (avg < 70)
            //    {
            //        Console.WriteLine("🤝 Don’t be discouraged—consider extra help and keep practicing.");
            //    }
            //    else  
            //    {
            //        Console.WriteLine("👍 Good job! Keep striving to improve!");
            //    }

            //    Console.WriteLine(new string('-', 40));
            //}


            //Task 4


            Car myCar = new Car("Chevrolet", "Monza", 2024);

            myCar.Drive(10);

            myCar.AddFuel(15);

            myCar.Drive(100);

            myCar.AddFuel(90);

            myCar.Drive(100);
        }
    }
}
    

    


