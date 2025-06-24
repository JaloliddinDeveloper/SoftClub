using HomeWork_15.Classes;
//Task 1:

//Car car = new Car(0);
//Console.Write("Enter gasoline amount to refuel: ");
//int fuel = int.Parse(Console.ReadLine());

//car.Refuel(fuel);
//car.Drive();

//Task 2:

//Console.Write("Enter dog name: ");
//string dogName = Console.ReadLine();

//Dog dog = new Dog();
//dog.SetName(dogName);

//Console.WriteLine(dog.GetName());
//dog.Eat();

//Task 3:
Book myBook = new Book();

Console.Write("Enter book title: ");
string title = Console.ReadLine();

Console.Write("Enter book author: ");
string author = Console.ReadLine();

myBook.SetTitle(title);
myBook.SetAuthor(author);

myBook.Read();
myBook.Borrow();
myBook.ReturnBook();