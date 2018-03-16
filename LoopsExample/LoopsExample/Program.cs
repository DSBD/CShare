using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ForExample1();
            Console.WriteLine();
            ForExample2();
            Console.WriteLine();
            ForEachExample();
        }

        public static void ForExample1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ForExample2()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void ForEachExample()
        {
            List<double> grades = new List<double>();
            grades.Add(50);
            grades.Add(10);
            grades.Add(99);
            grades.Add(75);
            grades.Add(80);
            grades.Add(90);

            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            double average = sum / grades.Count;

            Console.WriteLine(Math.Round(average, 2));
        }
    }
}
