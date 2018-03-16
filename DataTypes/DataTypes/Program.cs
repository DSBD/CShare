using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int number1, number2;

            System.Console.Write("Enter Number 1: ");
            number1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter Number 2: ");
            number2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"\n{number1} + {number2} = {number1 + number2}");
            System.Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            System.Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            System.Console.WriteLine($"{number1} x {number2} = {number1 * number2}");

            Console.ReadLine();
        }
    }
}