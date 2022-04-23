using System;
using System.Collections.Generic;   // needed for Lists

namespace listInterface
{
  class Program
  {
    static void Main(string[] args)
    { 

        // Create a list of Employees
        List<Employee> employeeList = new List<Employee>();

        // Add a couple of employees to the list to test
        employeeList.Add(new Employee ("Enge", "Alec", "H"));
        employeeList.Add(new Employee ("Enge", "J.S.", "S"));    

        // Print the list
        foreach (Employee anEmployee in employeeList)
        {
            Console.WriteLine(anEmployee);
        }  // end foreach  

    } // end Main

  }  // end class Program

}  // end nameSspace
