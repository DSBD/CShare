using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EminExample
{
    public enum Temprature
    {
        low = -20 ,
        medium = 5,
        high = 30
    }

    class Program
    {
        static void Main(string[] args)
        {
            Temprature temp;
            temp = Temprature.low;
            if (temp == Temprature.high)
            {

            }
        }
    }
}
