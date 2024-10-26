using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("blue", 4, 5));
        shapes.Add(new Circle("green", 3));

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The shape's color is: {shape.GetColor()}");
            Console.WriteLine($"The shape's area is: {shape.GetArea()}");
        }
    }
}
