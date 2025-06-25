# 💻 C# OOP Practice – Tasks 1, 2, and 3

This repository contains three object-oriented programming tasks in C# to help understand core principles like inheritance, interfaces, encapsulation, and polymorphism. Each task includes specific classes, behaviors, and output expectations.

---

## ✅ Task 1: 👨‍🏫 People — Student and Teacher

### 📋 Description

This task demonstrates **inheritance and method overriding** in C#. The `Person` class acts as the base class, with `Student` and `Teacher` classes inheriting and extending its functionality.

### 📂 Classes
- `Person.cs`: Base class with `Greet()` and `SetAge(int age)`
- `Student.cs`: Inherits from `Person`, adds `Study()` and `ShowAge()`
- `Teacher.cs`: Inherits from `Person`, adds `Explain()`
- `Program.cs`: Contains test logic
- 
![Picture](https://github.com/JaloliddinDeveloper/SoftClub/blob/main/HomeWork_10/Pictures/pic161.jpg?raw=true)



---

## ✅ Task 2: 🧱 UML-Based Shape System

### 📋 Description

This task focuses on **inheritance and encapsulation** using a class diagram.

### 📂 Class Diagram Overview

- `Shape`: Base class with a private attribute `color`
- `Rectangle`: Inherits from `Shape`, has private `length` and `width`
- `Circle`: Inherits from `Shape`, has private `radius`

### 🔧 Features

- Constructors for each class to initialize their private fields
- Inheritance ensures common structure while allowing unique properties

### 🔄 Relationships

- `Shape` ⬅️ `Rectangle`, `Circle` (Inheritance)

![Picture](https://github.com/JaloliddinDeveloper/SoftClub/blob/main/HomeWork_10/Pictures/pic162.jpg?raw=true)

## ✅ Task 3: 🏠 Smart Home Device Control System

### 📋 Description

Simulate a smart home with devices like lamps, thermostats, and locks using **interfaces and polymorphism**.

### 🔌 Interface: `IDevice`

All device classes implement:
- `TurnOn()`: Activates the device
- `TurnOff()`: Deactivates the device

### 📂 Devices

- `Lamp`: Has brightness control with `SetBrightness(int level)`
- `Thermostat`: Supports temperature adjustment via `SetTemperature(double temp)`
- `Lock`: Allows `LockDoor()` and `UnlockDoor()` methods

### 📌 Sample Output

![Picture](https://github.com/JaloliddinDeveloper/SoftClub/blob/main/HomeWork_10/Pictures/pic163.jpg?raw=true)
