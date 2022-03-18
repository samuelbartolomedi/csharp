using System;
using ExeAula136.Entities;
using ExeAula136.Entities.Enums;
using System.Collections.Generic;

namespace ExeAula136
{
    class ExeAula145
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Inform the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color? (black/blue/red) ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
