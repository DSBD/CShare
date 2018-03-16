using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystemExample.LogClasses
{
    class ConsoleLogger : ILogger
    {
        public void HandleEvent(string info)
        {
            Console.WriteLine(info);
        }
    }
}
