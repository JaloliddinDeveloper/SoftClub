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

### 💻 Misol:
```csharp
Laptop laptop = new Laptop("Dell", "Intel i7", 16, 8);
laptop.DisplayInfo();
laptop.Charge();
 ![Homework](https://github.com/JaloliddinDeveloper/SoftClub/blob/main/HomeWork_10/Pictures/inpic1.jpg)
 ![Homework](https://github.com/JaloliddinDeveloper/SoftClub/blob/main/HomeWork_10/Pictures/inpic1.jpg)
