using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            circleTest();
            rectangleTest();

            Console.ReadLine();
        }

        static void circleTest()
        {
            //Test Code for Circle Class Below

            Circle testCircle1 = new Circle(20.5);
            double testC1Area = testCircle1.getArea();
            double testC1Perimeter = testCircle1.getPerimeter();
            Console.WriteLine($"The Circle has a radius of {testCircle1.radius} an area of {Math.Round(testC1Area, 2)}, and a perimeter of {Math.Round(testC1Perimeter, 2)}");

            Circle testCircle2 = new Circle();
            testCircle2.radius = 12;

            Console.WriteLine($"The Circle has a radius of {testCircle2.radius} and and area of {Math.Round(testCircle2.getArea(), 2)}, and a perimeter of {Math.Round(testCircle2.getPerimeter(), 2)}");

        }

        static void rectangleTest()
        {
            //Test code for rectangle class

            Rectangle testRectrangle = new Rectangle(15, 20);
            double testRectangleArea = testRectrangle.getArea();
            double testRectanglePerimiter = testRectrangle.getPerimiter();
            Console.WriteLine($"Rectangle Area = {testRectangleArea}, Rectrangle Perimiter = {testRectanglePerimiter}");
        }
    }
}
