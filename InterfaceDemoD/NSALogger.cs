using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoD
{
    /// <summary>
    /// Logs messages to the NSA
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 10, 2023</remarks>
    internal class NSALogger : ILoggerDriver
    {
        /// <summary>
        /// Logs message to NSA
        /// </summary>
        /// <param name="message">Message</param>
        public void Log(string message)
        {
            // Send to terminal window
            Console.WriteLine("Sending to NSA: " + message);
        }
    }
}
