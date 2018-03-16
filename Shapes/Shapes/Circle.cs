using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Circle
    {
        public double radius { get; set; }

        public Circle(double r)
        {
            radius = r;
        }

        public Circle()
        {
            //Empty Constructor for Flexability
        }

        public double getArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

        public double getPerimeter()
        {
            double perimeter = 2 * Math.PI * radius;

            return perimeter;
        }
    }
}
