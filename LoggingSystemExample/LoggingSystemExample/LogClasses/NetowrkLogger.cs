using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoggingSystemExample.LogClasses
{
    class NetowrkLogger : ILogger
    {
        public void HandleEvent(string info)
        {
            //TODO Save Data to Remote Server
        }
    }
}
