using System;

namespace InterfaceNoDI
{
    public class ProductService
    {
        public void Log (string message)
        {
            ILogger logger = new FileLogger();    //Class options include FileLogger and DataBaseLogger (and any new ones)
            logger.Log(message);
        }

    }
}