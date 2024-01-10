/*

Program description: This program obtains a number of yards from the user, converts that to feet, and provides the equivalent number of feet to the user,
  or provides an error message if the number of years is < 0

Programmer: Alec Engebretson
Last update: January 2, 2024

Requirements:
(1) The number of yards will be an integer obtained from user that is greater than 0
(2) The number of feet will be calculated by taking the number of yards times 3 if the number of yards is greater than 0
(3) The number of feet will be an integer

Algorithm:

(1) do
    (a) Prompt the user for the number of yards
    (b) Obtain the number of yards from the user
    (c) If the number of yards <= 0
        Provide an error message
    while yards <= 0

(2) Calculate the number of feet by taking the number of yards * 3
(3) Output the number of feet

*/

using System; 

namespace YardsToFeet 
{ 
  class Program
  { 
    static void Main(string[] args)
    {
      int numberOfYards = 0;
      do {
        //Prompt the user for the number of yards
        Console.WriteLine("Please enter the number of yards: ");

        //Obtain the number of yards from the user
        numberOfYards = Convert.ToInt32(Console.ReadLine());

        // Error message
        if (numberOfYards <= 0) 
           {
            Console.WriteLine ("Please enter a value greater than 0");
           }
      } while (numberOfYards <= 0);


        //Calculate the number of feet by taking the number of yards * 3
        int numberOfFeet = numberOfYards * 3;
        //Output the number of feet
        Console.WriteLine("The number of feet in " + numberOfYards + " yards is " + numberOfFeet + " feet.");

    
  }
 }
}


