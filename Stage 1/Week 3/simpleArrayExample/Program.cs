using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car[] myCarArray = new Car[25];

      myCarArray[0] = new Car();  // test the first constructor
      
      myCarArray[1] = new Car("green","CRV");   // test the second constructor
      
      Console.WriteLine(myCarArray[0].getColor());
      Console.WriteLine(myCarArray[0].getModel());    

      Console.WriteLine(myCarArray[1].getColor());
      Console.WriteLine(myCarArray[1].getModel());      

      myCarArray[0].setColor("red");
      myCarArray[0].setModel("Mustang");

      Console.WriteLine(myCarArray[0].getColor());
      Console.WriteLine(myCarArray[0].getModel());      

      for (int theRest = 2; theRest < myCarArray.Length; theRest++)
      {
        myCarArray[theRest] = new Car();
      }    

      for (int allCars = 0; allCars < myCarArray.Length; allCars++)
      {
        Console.WriteLine(myCarArray[allCars]);
      }    

    }
  }
}