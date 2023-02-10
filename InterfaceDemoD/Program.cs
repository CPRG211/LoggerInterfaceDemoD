using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InterfaceDemoD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Does something");

            //StreamWriter streamWriter;
            //streamWriter = File.AppendText("log.txt");

            //streamWriter.WriteLine("Does something");

            //streamWriter.Flush();

            //streamWriter.WriteLine("Does something else");
            //streamWriter.Flush();

            //streamWriter.Close();

            //FileLogger fileLogger = new FileLogger();

            //fileLogger.Log("Does something");
            //fileLogger.Log("Does something else");

            //NSALogger nsaLogger= new NSALogger();

            //nsaLogger.Log("Listening to music");

            //ILoggerDriver logger = new NSALogger();
            ILoggerDriver logger = new FileLogger("log.txt");

            logger.Log("Does something");
            logger.Log("Does something else");
        }
    }
}
