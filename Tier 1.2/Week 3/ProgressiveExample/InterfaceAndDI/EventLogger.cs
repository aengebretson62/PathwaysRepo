using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndDI
{
    public class EventLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of EventLogger.");
            LogToEvent(message);
        }
        private void LogToEvent(string message)
        {
            Console.WriteLine("Method: LogToEvent, Text: {0}", message);
        }
    }
}
