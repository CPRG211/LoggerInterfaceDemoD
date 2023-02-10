using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoD
{
    /// <summary>
    /// Logs messages to a file.
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 10, 2023</remarks>
    internal class FileLogger : ILoggerDriver
    {
        private StreamWriter streamWriter;

        public FileLogger(string fileName) {
            // Open file for appending
            this.streamWriter = File.AppendText(fileName);
        }

        public void Log(string message)
        {
            // Write message (to memory)
            this.streamWriter.WriteLine(message);
            // Flush message (transfer from memory to hard drive)
            this.streamWriter.Flush();
        }
    }
}
