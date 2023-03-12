using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndDI
{
    public class CloudLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of CloudLogger.");
            LogToCloud(message);
        }
        private void LogToCloud(string message)
        {
            Console.WriteLine("Method: LogToCloud, Text: {0}", message);
        }
    }
}
