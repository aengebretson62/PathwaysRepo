/*

Program description: This program obtains a number of yards from the user, converts that to feet, and provides the equivalent number of feet to the user,
  or provides an error message if the number of years is < 0

Programmer: Alec Engebretson
Last update: July 18, 2023

Requirements:
(1) The number of yards will be an integer obtained from user that is greater than 0
(2) The number of feet will be calculated by taking the number of yards times 3 if the number of yards is greater than 0
(3) The number of feet will be an integer

Algorithm:

(1) Prompt the user for the number of yards
(2) Obtain the number of yards from the user
(3) If the number of yards > 0
     (3a) Calculate the number of feet by taking the number of yards * 3
     (3b) Output the number of feet
    Else
     (4a) Provide an error message

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
        //(1) Prompt the user for the number of yards
        Console.WriteLine("Please enter the number of yards: ");

        //(2) Obtain the number of yards from the user
        numberOfYards = Convert.ToInt32(Console.ReadLine());

        // Error message
        if (numberOfYards <= 0) 
           {
            Console.WriteLine ("Please enter a value greater than 0");
           }
      } while (numberOfYards <= 0);


            //(3)Calculate the number of feet by taking the number of yards * 3
            int numberOfFeet = numberOfYards * 3;
            //(4) Output the number of feet
            Console.WriteLine("The number of feet in " + numberOfYards + " yards is " + numberOfFeet + " feet.");

    }
  }
}

