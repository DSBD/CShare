using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 5;

            price = price >= 10 ? 9.50 : 10.00;
        }
    }
}
