# 🧠 Inheritance Practice – C# OOP Projects

Bu repository C# dasturlash tilida **obyektga yo‘naltirilgan dasturlash (OOP)** asoslarini o‘rganish uchun ikki vazifani o‘z ichiga oladi. Har bir taskda `class`, `inheritance`, `constructor`, va `method` lar ishlatilgan.

---

## 📌 Task 1: Computer, Laptop va SmartPhone sinflari

### 🔧 Tavsif:
- `Computer` — ota sinf bo‘lib, umumiy maydon va metodlarga ega.
- `Laptop` va `SmartPhone` — `Computer` sinfidan meros olgan voris sinflardir.

### 🧱 Sinf tuzilmasi:
- `Computer`: brand, processor, ram, Start(), DisplayInfo()
- `Laptop`: batteryLife, Charge()
- `SmartPhone`: cameraResolution, TakePhoto()


 ![Homework](https://github.com/JaloliddinDeveloper/SoftClub/blob/main/HomeWork_10/Pictures/inpic1.jpg)

## 🔧 Asosiy sinf: `Transport`

### Umumiy xususiyatlar:
- `Name` – transport nomi
- `Speed` – tezlik (km/soat)
- `Capacity` – sig‘imi (yo‘lovchilar yoki yuk)

### Metod:
- `DisplayInfo()` – transport haqida ma’lumot chiqaradi

---

## 🚗 `Car` sinfi

### Voris sinflari:
- **`PassengerCar`** – `NumberOfSeats` (o‘rindiqlar soni)
- **`CargoCar`** – `LoadCapacity` (yuk sig‘imi, kg)

---

## ✈️ `Airplane` sinfi

### Voris sinflari:
- **`PassengerPlane`** – `FlightRange` (uchish masofasi, km)
- **`CargoPlane`** – `MaxCargoWeight` (maksimal yuk, kg)

---

## 🚄 `Train` sinfi

- `NumberOfWagons` – vagonlar soni

---

## 💻 Koddan misollar

```csharp
PassengerCar yengilAvtomobil = new PassengerCar("Toyota", 180, 5, 5);
yengilAvtomobil.DisplayInfo();

CargoPlane yukSamolyoti = new CargoPlane("Antonov AN-124", 750, 6, 120000);
yukSamolyoti.DisplayInfo();

Train tezyurarPoyezd = new Train("Tezyurar Poyezd", 300, 600, 16);
tezyurarPoyezd.DisplayInfo();

 ![Homework2](https://github.com/JaloliddinDeveloper/SoftClub/blob/main/HomeWork_10/Pictures/inpic2.jpg)
