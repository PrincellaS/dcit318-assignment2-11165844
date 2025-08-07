using System;

namespace AbstractDemo
{
    // Abstract base class Shape
    public abstract class Shape
    {
        // Abstract method that must be implemented by derived classes
        public abstract double GetArea();

        // Non-abstract method that can be used by all derived classes
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"This shape has an area of: {GetArea():F2}");
        }
    }

    // Derived class Circle that inherits from Shape
    public class Circle : Shape
    {
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Property for radius
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Implementation of abstract method GetArea
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        // Override DisplayInfo to provide more specific information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {radius:F2} has an area of: {GetArea():F2}");
        }
    }

    // Derived class Rectangle that inherits from Shape
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        // Constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Properties for length and width
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        // Implementation of abstract method GetArea
        public override double GetArea()
        {
            return length * width;
        }

        // Override DisplayInfo to provide more specific information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with length {length:F2} and width {width:F2} has an area of: {GetArea():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===");
            Console.WriteLine();

            // Create instances of Circle and Rectangle
            Circle myCircle = new Circle(5.0);
            Rectangle myRectangle = new Rectangle(4.0, 6.0);

            // Display their areas using the overridden DisplayInfo method
            Console.WriteLine("Circle Information:");
            myCircle.DisplayInfo();

            Console.WriteLine("\nRectangle Information:");
            myRectangle.DisplayInfo();

            // Direct area calculation calls
            Console.WriteLine("\n--- Direct Area Calculations ---");
            Console.WriteLine($"Circle area: {myCircle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {myRectangle.GetArea():F2}");

            // Demonstrate polymorphism with abstract classes
            Console.WriteLine("\n--- Polymorphism with Abstract Classes ---");
            Shape[] shapes = { new Circle(3.0), new Rectangle(2.5, 4.0) };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Shape {i + 1}:");
                shapes[i].DisplayInfo();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}