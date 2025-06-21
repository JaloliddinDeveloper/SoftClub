//task 1:
//using HomeWork_14.Classes;

//var student = new Student("Ali", "Tashkent");
//student.AddCourseGrade("Math", 90);
//student.AddCourseGrade("Physics", 85);
//student.PrintGrades();
//Console.WriteLine("Average: " + student.GetAverageGrade());

//var teacher = new Teacher("Mr. Karim", "Samarkand");
//teacher.AddCourse("Math");
//teacher.AddCourse("Biology");
//teacher.PrintCourses();

//task 2:
using HomeWork_14.Practice;

int[] lastWeek = BirdCount.LastWeek();
Console.WriteLine("Last week's bird counts:");
foreach (int count in lastWeek)
{
    Console.Write(count + " ");
}

//task 7:
int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);

Console.WriteLine("Busy days: " + birdCount.BusyDays());