using System;

namespace NoInterfaceOrDI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService1 = new ProductService();
            productService1.LogToFile("First log to file");
            productService1.LogToDatabase("First log to database);");
        }
    }
}
