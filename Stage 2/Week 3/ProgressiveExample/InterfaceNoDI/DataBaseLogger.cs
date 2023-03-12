using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceNoDI
{
    public class DataBaseLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of DatabaseLogger.");
            LogToDatabase(message);
        }
        private void LogToDatabase(string message)
        {
            Console.WriteLine("Method: LogToDatabase, Text: {0}", message);
        }
    }
}
