using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Subtotal: ");
            double subTotal = double.Parse(Console.ReadLine());

            Console.Write("Enter the Tip Percentage: ");
            double tipPercentage = double.Parse(Console.ReadLine());

            double tipAmmount = subTotal * (tipPercentage / 100);

            double beforeTax = subTotal * (1 + (tipPercentage / 100));
            double finalTotal = beforeTax * 1.13;

            Console.WriteLine($"\nTip Ammount: ${Math.Round(tipAmmount, 2)}");
            Console.WriteLine($"Total Before Tax: ${Math.Round(beforeTax, 2)}");
            Console.WriteLine($"Total Ammount: ${Math.Round(finalTotal, 2)}");

            Console.ReadLine();
        }
    }
}
