using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticProperties
{
    class Program
    {
        static void doWork()
        {
            Polygon square = new Polygon();
            Polygon triangle = new Polygon
            {
                NumSides = 3
            };
            Polygon pentagon = new Polygon
            {
                NumSides = 5,
                SideLength = 15.5,
            };

            Console.Write($"Square\n\tNum Sides: {square.NumSides}\n\tSide Length: {square.SideLength} ");
            Console.Write($"\nTriangle\n\tNum Sides: {triangle.NumSides}\n\tSide Length: {triangle.SideLength} ");
            Console.Write($"\nPentagon\n\tNum Sides: {pentagon.NumSides}\n\tSide Length: {pentagon.SideLength} ");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
