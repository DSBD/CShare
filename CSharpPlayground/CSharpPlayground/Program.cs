using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            System.Console.WriteLine("OG X: " + x);

            int y = x;
            y = 30;

            System.Console.WriteLine("Y: " + y);
            System.Console.WriteLine("X: " + x);

            System.Console.Write("\nPress [ENTER] to Continue  ");
            System.Console.ReadLine();
        }
    }
}
