using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystemExample.LogClasses
{
    class FileLogger : ILogger
    {
        private string _filename;

        public FileLogger(string filename)
        {
            _filename = filename;
        }

        public void HandleEvent(string info)
        {
            FileStream fs = new FileStream(_filename, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(info);
            sw.Close();
            fs.Close();
        }
    }
}
