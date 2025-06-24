//task 1
//using Lesson_16.Classes;

//Shape aylana = new Circle(5.2);
//aylana.CalculateArea();
//aylana.PrintDescription();

//Shape tortburchak = new Rectangle(4,6);
//tortburchak.CalculateArea();
//tortburchak.PrintDescription();

//task 2
//using Lesson_16.ClassesTwo;

//IMovable car= new Car("Malibu", 220, "Black");
//Console.WriteLine(car.MoveLeft("Right"));
//Console.WriteLine(car.MoveRight("Left"));

//IMovable bus= new Bus("Mers", 140, "Green");
//Console.WriteLine(bus.MoveLeft("Left"));
//Console.WriteLine(bus.MoveRight("Left"));



//task 3:
using Lesson_16.ClassesThree;

var person1 = new BankAccount("111", "Jaloliddin", 1000);
var person2 = new BankAccount("222", "Oybek", 2000);
var person3 = new BankAccount("333", "Bobur", 3000);

person1.TopUp(500);
person1.Withdraw(100);
person1.PrintStatement();

person2.TopUp(500);
person2.Withdraw(100);
person2.PrintStatement();

person3.TopUp(500);
person3.Withdraw(100);
person3.PrintStatement();