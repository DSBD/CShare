using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystemExample.LogClasses
{
    class NetworkLogger : ILogger
    {
        public void HandleEvent(string info)
        {
          //todo: save info to remote machine
        }
    }
}
