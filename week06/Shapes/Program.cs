using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square = new Square("S_Color", 5);
        Rectangle rectangle = new Rectangle("R_Color", 4, 6);
        Circle circle = new Circle("C_Color", 3);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        Console.Clear();
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color : {shape.GetColor()}");
            Console.WriteLine($"Area  : {shape.GetArea()}");
            Console.WriteLine("---------------------------");
            
        }

    }
}