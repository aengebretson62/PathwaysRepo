using System;

namespace restaurantAPP
{
  class Program
  {
    static void Main(string[] args)
    { 
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


        // print each restaurant to test the property gets and the toString

        for (int index = 0; index < restaurantArray.Length; index++)
        {
            if (!(((restaurantArray[index]).getName())==null))
                Console.WriteLine(restaurantArray[index]);
        }

    } // Main
  } // class
} // namespace