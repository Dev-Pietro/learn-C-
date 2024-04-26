using System;
using System.Collections.Generic;
using Ex13.Entities;
using Ex13.Entities.Enums;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.WriteLine("Enter number of shapes:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data");
                Console.WriteLine("Rectangle or Circle (r/c) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r') {
                    Console.WriteLine("Width:");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height:");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, color));
                } else {
                    Console.WriteLine("Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Area():N2}");
            }

        }
    }
}