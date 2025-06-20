//Task 1:
using Homework_13.Classes;
using System;

Person[] people = new Person[3];

Console.Write("Enter the name of Student 1: ");
string student1Name = Console.ReadLine();
people[0] = new Student(student1Name);

Console.Write("Enter the name of Student 2: ");
string student2Name = Console.ReadLine();
people[1] = new Student(student2Name);

Console.Write("Enter the name of the Teacher: ");
string teacherName = Console.ReadLine();
people[2] = new Teacher(teacherName);

foreach (var person in people)
{
    if (person is Student student)
    {
        student.Study();
    }
    else if (person is Teacher teacher)
    {
        teacher.Explain();
    }
}

//Task 2:
//PhotoBook defaultBook = new PhotoBook();
//Console.WriteLine($"Default PhotoBook has {defaultBook.GetNumberPages()} pages.");

//PhotoBook customBook = new PhotoBook(24);
//Console.WriteLine($"Custom PhotoBook has {customBook.GetNumberPages()} pages.");

//BigPhotoBook bigBook = new BigPhotoBook();
//Console.WriteLine($"Big PhotoBook has {bigBook.GetNumberPages()} pages.");

//Task 3:   

//Console.Write("Enter the dog's name: ");
//string dogName = Console.ReadLine();

//Dog myDog = new Dog();
//myDog.SetName(dogName);

//Console.WriteLine($"Dog's name: {myDog.GetName()}");
//myDog.Eat();