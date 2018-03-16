using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes_Inheritance_Example
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, String type) : base(type)
        {
            Radius = radius;
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("I am a Circle");
        }
    }
}
