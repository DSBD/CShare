using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes_Inheritance_Example
{
    class Rectangle : Shape, IResizable
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double h, double w, string type) : base(type)
        {
            Height = h;
            Width = w;
        }

        public override double getArea()
        {
            return Height * Width;
        }

        public override double getPerimeter()
        {
            return 2 * (Height + Width);
        }

        public void Resize(int factor)
        {
            Height *= factor;
            Width *= factor;
        }
    }
}