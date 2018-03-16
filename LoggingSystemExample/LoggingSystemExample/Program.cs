using LoggingSystemExample.LogClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystemExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger infolog = new FileLogger("info.txt");
            ConsoleLogger consoleLog = new ConsoleLogger();

            // without static keyword
            //LoggingSystem ls = new LoggingSystem();
            //ls.AddLogger(log);

            // //no need to create an instance of LogSys as everything in the class is being defined as static
            LoggingSystem.AddLogger(new FileLogger("log.txt"));
            LoggingSystem.AddLogger(infolog);
            LoggingSystem.AddLogger(consoleLog);
            LoggingSystem.AddLogger(new NetworkLogger());


            LoggingSystem.LogInfo("System init!");

     

        }
    }
}
