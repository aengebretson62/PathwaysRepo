using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car myCar1 = new Car();  // test the first constructor
      
      Car myCar2 = new Car("green","CRV");   // test the second constructor
      
      Console.WriteLine(myCar1.getColor());
      Console.WriteLine(myCar1.getModel());    

      Console.WriteLine(myCar2.getColor());
      Console.WriteLine(myCar2.getModel());      

      myCar1.setColor("red");
      myCar1.setModel("Mustang");

      Console.WriteLine(myCar1.getColor());
      Console.WriteLine(myCar1.getModel());          
    }
  }
}