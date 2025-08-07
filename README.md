# dcit318-assignment2-11165844
# DCIT 318 Assignment 2 - Object-Oriented Programming in C#

## Overview
Three C# console applications demonstrating core OOP concepts:
- **InheritanceDemo** - Inheritance and Method Overriding
- **AbstractDemo** - Abstract Classes and Methods  
- **InterfaceDemo** - Interface Implementation

## Prerequisites
- .NET 6.0 or later
- Visual Studio Code

## How to Run
```bash
# Navigate to each project and run
cd InheritanceDemo && dotnet run
cd ../AbstractDemo && dotnet run
cd ../InterfaceDemo && dotnet run
```

## Applications

### 1. Inheritance Demo
- **Base class**: `Animal` with `MakeSound()` method
- **Derived classes**: `Dog` (prints "Bark"), `Cat` (prints "Meow")
- **Demonstrates**: Method overriding and polymorphism

### 2. Abstract Classes Demo
- **Abstract class**: `Shape` with abstract `GetArea()` method
- **Concrete classes**: `Circle` and `Rectangle` with area calculations
- **Demonstrates**: Abstract methods and implementation requirements

### 3. Interface Demo
- **Interface**: `IMovable` with `Move()` method
- **Implementations**: `Car` and `Bicycle` classes
- **Demonstrates**: Interface contracts and polymorphism

## Key OOP Concepts Covered
- **Inheritance**: Classes inheriting from base classes
- **Polymorphism**: Same method, different behaviors
- **Abstraction**: Abstract classes and interfaces
- **Encapsulation**: Properties and access modifiers

## Repository Structure
```
dcit318-assignment2-11165844/
├── InheritanceDemo/Program.cs
├── AbstractDemo/Program.cs
├── InterfaceDemo/Program.cs
└── README.md
```

---
**Student ID**: 11165844  
**Course**: DCIT 318
