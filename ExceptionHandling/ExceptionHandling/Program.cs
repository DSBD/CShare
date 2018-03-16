using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = getNumber("Enter Your Age: ");

            Console.WriteLine($"Your Age is {number}");
            Console.ReadLine();
        }

        static int getNumber(string message)
        {
            int number;

            while (true)
            {
                try
                {
                    Console.Write(message);
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Input Error");
                }
            }
            return number;
        }
    }
}
