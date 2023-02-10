using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoD
{
    internal class FileLogger : ILoggerDriver
    {
        private StreamWriter streamWriter;

        public FileLogger(string fileName) {
            this.streamWriter = File.AppendText(fileName);
        }

        public void Log(string message)
        {
            this.streamWriter.WriteLine(message);
            this.streamWriter.Flush();

        }
    }
}
