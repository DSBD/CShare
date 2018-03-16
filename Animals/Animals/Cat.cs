using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
