using System;

namespace InterfaceNoDI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService1 = new ProductService();
            productService1.Log("First log entry");
        }
    }
}
