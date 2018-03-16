using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystemExample
{
    interface ILogger
    {
        void HandleEvent(string info);
    }
}
