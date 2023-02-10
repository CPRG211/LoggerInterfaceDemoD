using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoD
{
    internal class NSALogger : ILoggerDriver
    {
        public void Log(string message)
        {
            Console.WriteLine("Sending to NSA: " + message);
        }
    }
}
