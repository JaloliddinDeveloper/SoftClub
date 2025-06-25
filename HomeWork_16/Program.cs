//Task 1:
//using HomeWork_16.ClassesOne;

//var student=new Student("Jaloliddin",25);
//var teacher = new Teacher();

//student.Greet();
//teacher.Greet();

//student.SetAge(24);
//teacher.SetAge(25);

//student.Study();
//student.ShowAge();

//teacher.Explain();

//Task 2:
//using HomeWork_16.ClassesTwo;

//Rectangle rectangle = new Rectangle(8, 15, "Green");
//Circle circle = new Circle(8, "Green");

//Console.WriteLine("Rectangle:");
//Console.WriteLine($"Area: {rectangle.Area()}");
//Console.WriteLine($"Perimeter: {rectangle.Peremetr()}");

//Console.WriteLine("Circle:");
//Console.WriteLine($"Area: {circle.Area():F2}");
//Console.WriteLine($"Perimeter: {circle.Peremetr():F2}");

//Task 3:
using HomeWork_16.Classes;

Console.WriteLine("SMART HOME SYSTEM");

Lamp lamp = new Lamp();
lamp.TurnOn();
lamp.SetBrightness(75);
lamp.TurnOff();

Console.WriteLine();

Thermostat thermostat = new Thermostat();
thermostat.TurnOn();
thermostat.SetTemperature(22.5);
thermostat.TurnOff();

Console.WriteLine();