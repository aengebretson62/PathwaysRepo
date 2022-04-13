using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { 
    
      Console.WriteLine("Enter an integer: ");
      int j = Int32.Parse(Console.ReadLine());
      while (j<=0)
      {
              Console.WriteLine("Integer must be > 0. Enter an integer: ");
              j = Int32.Parse(Console.ReadLine());
      }

      int i=0;
      while (i < j) 
      {
        Console.WriteLine(i);
        i++;
      }
    }
  }
}
