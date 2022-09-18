using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string fname) 
    {
      Console.WriteLine(fname + " Refsnes");
    }

    static void Main(string[] args)
    {
      string myName = "";
      for (int i=0; i<4; i++)
      {
        myName = Console.ReadLine();
        MyMethod(myName);
      }
    }  
  }
}