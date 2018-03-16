using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Rectangle
    {
        public int width;
        public int height;

        public Rectangle(int rectwidth, int rectheight)
        {
            width = rectwidth;
            height = rectheight;
        }

        public double getArea()
        {
            double area = width * height;

            return area;
        }

        public double getPerimiter()
        {
            double perimiter = 2 * (width + height);

            return perimiter;
        }
    }
}
