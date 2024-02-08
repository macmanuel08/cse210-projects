using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("blue", 50);
        Rectangle rectangle1 = new Rectangle("black", 100, 60);
        Circle circle1 = new Circle("red", 30);
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine("");
        }
    }
}