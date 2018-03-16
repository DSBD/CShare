using LoggingSystemExample.LogClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystemExample
{
    class LoggingSystem
    {
        public static List<ILogger> Loggers { get; set; }

        static LoggingSystem()
        {
            Loggers = new List<ILogger>();
        }


        public static void LogInfo(string info)
        {
            foreach (ILogger logger in Loggers)
            {
                logger.HandleEvent(info);
            }
        }

        public static void AddLogger(ILogger logger)
        {
            Loggers.Add(logger);
        }

    }
}
