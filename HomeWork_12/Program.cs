//Task 1:

//using HomeWork_12.ClassesOne;

//Laptop laptop = new Laptop("Lenavo", "Ryzen 5", 16, 8);
//laptop.Start();
//laptop.DisplayInfo();
//laptop.Charge();

//SmartPhone phone = new SmartPhone("Samsung", "Snapdragon 8", 8, 108);
//phone.Start();
//phone.DisplayInfo();
//phone.TakePhoto();

//Task 2:
using HomeWork_12.ClassesTwo;

PassengerCar yengilAvtomobil = new PassengerCar("Toyota", 180, 5, 5);
yengilAvtomobil.DisplayInfo();
Console.WriteLine();

CargoCar yukMashina = new CargoCar("Volvo Yuk Mashinasi", 120, 2, 10000);
yukMashina.DisplayInfo();
Console.WriteLine();

PassengerPlane yoLovchiSamolyot = new PassengerPlane("Boeing 737", 850, 180, 5000);
yoLovchiSamolyot.DisplayInfo();
Console.WriteLine();

CargoPlane yukSamolyoti = new CargoPlane("Antonov AN-124", 750, 6, 120000);
yukSamolyoti.DisplayInfo();
Console.WriteLine();

Train tezyurarPoyezd = new Train("Tezyurar Poyezd", 300, 600, 16);
tezyurarPoyezd.DisplayInfo();
