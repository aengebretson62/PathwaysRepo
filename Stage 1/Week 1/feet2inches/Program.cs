using System;

namespace Feet2Inches
{
  class Program
  {
    static void Main(string[] args)
    {
            double inch;
            Console.Write("Input Value (Feet)  : ");
            double feet = Convert.ToDouble(Console.ReadLine());
            inch = feet*12; 
 
            Console.WriteLine("{0} Feet  : {1} Inches", feet, inch);
            Console.ReadKey();    
    }
  }
}