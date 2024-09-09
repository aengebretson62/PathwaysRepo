using System;

namespace InterfaceAndDI
{
    public class ProductService : ILogger
    {
        private readonly ILogger _logger;
        public ProductService(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log(message);   
        }
    }
}