using System;

namespace InterfaceAndDI
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger loggerFile = new CloudLogger();
            ProductService productService1 = new ProductService(loggerFile);
            productService1.Log("New log entry.");

        }
    }
}
