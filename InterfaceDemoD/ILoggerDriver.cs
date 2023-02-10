using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoD
{
    /// <summary>
    /// Logger driver interface
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Feb 10, 2023</remarks>
    internal interface ILoggerDriver
    {
        /// <summary>
        /// Logs a message
        /// </summary>
        /// <param name="message">Message to log</param>
        void Log(string message);
    }
}
