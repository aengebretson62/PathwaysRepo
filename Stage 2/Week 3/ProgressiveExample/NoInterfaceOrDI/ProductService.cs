using System;

namespace NoInterfaceOrDI
{
    public class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger();
        private readonly DatabaseLogger _databaseLogger = new DatabaseLogger();
        public void LogToFile(string message)
        {
            _fileLogger.Log(message);
        }
        public void LogToDatabase(string message)
        {
            _databaseLogger.Log(message);
        }
    }
}