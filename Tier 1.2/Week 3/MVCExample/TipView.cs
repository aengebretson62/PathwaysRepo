using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample
{
    class TipView
    {
        /// 

        /// this is the TipView class. Its purpose is
        /// to gather the input and display the output

        //constructor
        public TipView()
        {

        }

        public double GetAmountValue()
        {
            Console.WriteLine("Enter the Amount of the meal");
            double amt = double.Parse(Console.ReadLine());

            return amt;
        }

        public double GetPctValue()
        { 
            Console.WriteLine("Enter the percent you want to tip");
            double percentage = double.Parse(Console.ReadLine());

            return percentage;
        }
        public void ShowTipandTotal(double tipAmount, double total)
        {
            Console.WriteLine("Your tip is {0:C}", tipAmount);
            Console.WriteLine("The total will be {0:C}", total);
            Console.ReadKey();
        }

    }
}
