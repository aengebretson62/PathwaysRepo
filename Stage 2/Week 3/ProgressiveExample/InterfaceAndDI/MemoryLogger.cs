using System;

namespace InterfaceAndDI
{
    public class MemoryLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of MemoryLogger.");
            LogToMemory(message);
        }
        private void LogToMemory(string message)
        {
            Console.WriteLine("Method: LogToMemory, Text: {0}", message);
        }
    }
}
