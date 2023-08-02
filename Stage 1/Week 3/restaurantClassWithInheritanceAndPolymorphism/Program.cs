using System;

namespace restaurantAPP
{
  class Program
  {
    static void Main(string[] args)
    { 
        Restaurant rest1 = new Restaurant();    // test the first constructor for Restaurant
        Restaurant rest2 = new Restaurant("Dominos", 2);
        Console.WriteLine(rest1);
        Console.WriteLine(rest2);
        Console.WriteLine();


        // Declare and instantiate the array of Restaurant objects
        Restaurant[] restaurantArray=new Restaurant[25];

        // Now, loop through each array element and instantiate a Restaurant object for each.
        // Note that the constructor with no parameters will be used.

        for (int index = 0; index < restaurantArray.Length; index++)
        {
            restaurantArray[index] = new Restaurant();
        }

        // Load in some test data to test both ways to assign values

        restaurantArray[1].setName("McDonalds");
        restaurantArray[1].RRating = 2;
        restaurantArray[10].setName("Lazlos");
        restaurantArray[10].RRating = 4;
        restaurantArray[20].setName("Venue");
        restaurantArray[20].RRating = 5;
        restaurantArray[3] = rest1;
        restaurantArray[6] = rest2;


        // print each restaurant to test the property gets and the toString

        for (int index = 0; index < restaurantArray.Length; index++)
        {
            if (!(((restaurantArray[index]).getName())==null))
                Console.WriteLine(restaurantArray[index]);
        }
        Console.WriteLine();

      // FineDining class
      // test the inheritance with default constructor
      FineDining fine1 = new FineDining();
      Console.WriteLine(fine1);
      // test with the other constructor
      FineDining fine2 = new FineDining("MoMos",3,false);
      Console.WriteLine(fine2);
      // make some changes on the properties
      fine2.RReservation = true;
      fine2.RRating = 4;
      Console.WriteLine(fine2);
      Console.WriteLine();

      // test adding a FineDining to the restaurantArray
      restaurantArray[15]=fine2;

      // FastFood class
      // test the inheritance with default constructor
      FastFood fast1 = new FastFood();
      Console.WriteLine(fast1);
      // test with the other constructor
      FastFood fast2 = new FastFood("BK",2,true);
      Console.WriteLine(fast2);

      // test adding FastFood to the restaurantArray
      restaurantArray[24] = fast2;

      // print each restaurant to test the property gets and the toString
        Console.WriteLine("\n\nMixing Restaurant and FineDining and FastFood objects in the array.");
        for (int index = 0; index < restaurantArray.Length; index++)
        {
            if (!(((restaurantArray[index]).getName())==null))
                Console.WriteLine(restaurantArray[index]);
        }

    } // Main
  } // class
} // namespace