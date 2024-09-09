using System;

namespace Feet2Inches
{
  class Program
  {
    static void MainB(string[] args)
    {
      /* Program description: This program will take a string from the user which will be the number of feet, convert to a double, 
          calculate the number of fee to the number of inches, and output the number of inches.

          Algorithm
          I.   Prompt the user for number of feet
          II.  Obtain the number of feet from the user
          III. Convert the number of feet to number of inches
          IV.  Output the number of inches

      */

            double inch;       // inch will contain the number of inches calcuated

            // I.   Prompt the user for number of feet
            Console.Write("Input Value (Feet)  : ");

            // II.  Obtain the number of feet from the user
            double feet = Convert.ToDouble(Console.ReadLine());    // feet will contain the number of feet the user enters (converted from string to double)
            
            //III. Convert the number of feet to number of inches
            inch = feet*12; 
            
            //IV.  Output the number of inches
            Console.WriteLine("{0} Feet  : {1} Inches", feet, inch);
            Console.ReadKey();    

    }
  }
}