using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes_Inheritance_Example
{
    abstract class Shape
    {
        protected String _colour;
        protected String _type;

        public String Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public abstract double getArea();
        public abstract double getPerimeter();

        public Shape(string type)
        {
            _type = type;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Area: {getArea()}, Perimeter: {getPerimeter()}";
        }

        public virtual void Draw()
        {
            Console.WriteLine("I am a Cool Shape :)");
        }
    }
}
