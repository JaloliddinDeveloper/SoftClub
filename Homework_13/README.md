# 👨‍💻 C# OOP Practice Tasks

This repository contains three object-oriented programming tasks implemented in C#. Each task demonstrates a core concept of object-oriented design such as inheritance, encapsulation, and abstraction.

---

## ✅ Task 1: People — Students and Teacher

### 📋 Description:
- Create a `Person` class with a `Name` property and `ToString()` method.
- Inherit `Student` and `Teacher` from `Person`.
- `Student` class includes a `Study()` method.
- `Teacher` class includes an `Explain()` method.
- Store 2 students and 1 teacher in an array, call their respective methods.

![Task 1 Screenshot](https://raw.githubusercontent.com/JaloliddinDeveloper/SoftClub/main/HomeWork_10/Pictures/pic131.jpg)

---

## ✅ Task 2: Photo Book Class

### 📋 Description:
- Create a `PhotoBook` class with a private `numPages` field (default 16 pages).
- Add an overloaded constructor to allow setting a custom number of pages.
- Create a `BigPhotoBook` class inheriting from `PhotoBook`, with 64 pages by default.
- Implement `GetNumberPages()` method.
- Create a test class that:
  - Creates a default photo book.
  - Creates a photo book with 24 pages.
  - Creates a big photo book.

![Task 2 Screenshot](https://raw.githubusercontent.com/JaloliddinDeveloper/SoftClub/main/HomeWork_10/Pictures/pic132.jpg)

## ✅ Task 3: Abstract Class — Animal

### 📋 Description:
- Define an abstract class `Animal` with:
  - A `Name` property
  - `SetName(string)` and `GetName()` methods
  - An abstract `Eat()` method
- Create a `Dog` class that inherits from `Animal` and overrides `Eat()`.
- In the test class:
  - Ask the user to enter the dog’s name
  - Set the name using `SetName()`
  - Display it using `GetName()`
  - Call the `Eat()` method

![Task 3 Screenshot](https://raw.githubusercontent.com/JaloliddinDeveloper/SoftClub/main/HomeWork_10/Pictures/pic133.jpg)
