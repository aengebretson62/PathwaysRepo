using System;

namespace Calculator
{
    class Calculator
    {
        private double num1;   // first private attribute/class variable accessible only through methods
        private double num2;   // second private attribute/class variable accessible only through methods

        public Calculator()    // constructor method that initializes both values to 0;
        {
            num1 = 0;
            num2 = 0;
        }
        public double Number1  // property for num1 to declare the accessor and mutator
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Number2  // property for num1 to declare the accessor and mutator
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double DoOperation(string op)  // public method to do an operation
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // check for a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalc = new Calculator();  // myCalc is the object of the class Calculator

            bool endApp = false;                   // local variable to flag when to end the application

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                // Get the first valid number from the user
                Console.Write("First number - ");
                myCalc.Number1 = getDoubleFromUser();

                // Get the first valid number from the user
                Console.Write("Second number - ");
                myCalc.Number2 = getDoubleFromUser();

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine().ToLower();

                try
                {
                    double result = myCalc.DoOperation(op);  // invokes the DoOperation method of the object and passes the operation

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation can not be performed.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }  // end while loop
            return;
        } // end main

        static double getDoubleFromUser()  // static method to get a number from the user since we do it a couple of times
        {
            // Ask the user to type the number.
            Console.Write("Type a number, and then press Enter: ");
            // Get the input
            string numInput = Console.ReadLine();
            // See if it is a number
            double cleanNum = 0;
            while (!double.TryParse(numInput, out cleanNum))
            {
                Console.Write("This is not valid input. Please enter a number: ");
                numInput = Console.ReadLine();
            }
            return cleanNum;
        }

    } // end class Program
}
