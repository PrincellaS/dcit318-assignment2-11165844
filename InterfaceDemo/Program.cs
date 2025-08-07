using System;

namespace InterfaceDemo
{
    // Interface definition
    public interface IMovable
    {
        // Interface method - no implementation, only signature
        void Move();
        
        // Optional: Interface can also have properties
        int Speed { get; set; }
    }

    // Class Car that implements IMovable interface
    public class Car : IMovable
    {
        private int speed;

        // Constructor
        public Car(int speed = 60)
        {
            this.speed = speed;
        }

        // Implementation of the Speed property from IMovable
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        // Implementation of the Move method from IMovable
        public void Move()
        {
            Console.WriteLine($"Car is moving at {speed} km/h");
        }

        // Additional method specific to Car
        public void Honk()
        {
            Console.WriteLine("Car is honking: Beep! Beep!");
        }
    }

    // Class Bicycle that implements IMovable interface
    public class Bicycle : IMovable
    {
        private int speed;

        // Constructor
        public Bicycle(int speed = 15)
        {
            this.speed = speed;
        }

        // Implementation of the Speed property from IMovable
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        // Implementation of the Move method from IMovable
        public void Move()
        {
            Console.WriteLine($"Bicycle is moving at {speed} km/h");
        }

        // Additional method specific to Bicycle
        public void RingBell()
        {
            Console.WriteLine("Bicycle bell: Ring! Ring!");
        }
    }

    // Additional class to demonstrate interface usage
    public class Airplane : IMovable
    {
        private int speed;

        public Airplane(int speed = 800)
        {
            this.speed = speed;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void Move()
        {
            Console.WriteLine($"Airplane is flying at {speed} km/h");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Implementation Demo ===");
            Console.WriteLine();

            // Create instances of Car and Bicycle
            Car myCar = new Car(80);
            Bicycle myBicycle = new Bicycle(20);

            // Call the Move() method on each instance
            Console.WriteLine("Direct method calls:");
            myCar.Move();
            myBicycle.Move();

            // Demonstrate class-specific methods
            Console.WriteLine("\nClass-specific methods:");
            myCar.Honk();
            myBicycle.RingBell();

            // Demonstrate interface polymorphism
            Console.WriteLine("\n--- Interface Polymorphism Demo ---");
            IMovable[] movableObjects = { 
                new Car(100), 
                new Bicycle(25), 
                new Airplane(900) 
            };

            for (int i = 0; i < movableObjects.Length; i++)
            {
                Console.WriteLine($"Movable Object {i + 1}:");
                movableObjects[i].Move();
                Console.WriteLine($"Speed: {movableObjects[i].Speed} km/h");
                Console.WriteLine();
            }

            // Demonstrate interface reference
            Console.WriteLine("--- Using Interface References ---");
            IMovable vehicle1 = new Car(120);
            IMovable vehicle2 = new Bicycle(30);

            vehicle1.Move();
            vehicle2.Move();

            // Modify speeds through interface
            vehicle1.Speed = 140;
            vehicle2.Speed = 35;

            Console.WriteLine("\nAfter speed modification:");
            vehicle1.Move();
            vehicle2.Move();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}