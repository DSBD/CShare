using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes_Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Circle(10, "Circle");
            double area = s.getArea();

            List<Shape> shapes = new List<Shape>();

            Circle c = new Circle(10, "Circle");
            Rectangle r = new Rectangle(10, 4, "Rectangle");

            shapes.Add(c);
            shapes.Add(r);

            Rectangle r2 = new Rectangle(5, 10, "Rectangle");
            Console.WriteLine(r2.ToString());
            r2.Resize(2);
            Console.WriteLine(r2.ToString());
        }
    }
}
