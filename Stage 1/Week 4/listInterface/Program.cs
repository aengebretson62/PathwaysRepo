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

        // Add a couple of hourly employees to the list to test
        employeeList.Add(new HourlyEmployee ("Enge", "Colin", "H", 15.75));
        employeeList.Add(new HourlyEmployee ("Enge", "Elle", "H", 25.73));    

        // Add a couple of hourly employees to the list to test
        employeeList.Add(new SalaryEmployee ("Enge", "Anthony", "S", 45250));
        employeeList.Add(new SalaryEmployee ("Enge", "Molly", "S", 60000)); 

        // Print the list
        foreach (Employee anEmployee in employeeList)
        {
            Console.WriteLine(anEmployee);
        }  // end foreach  

    } // end Main

  }  // end class Program

}  // end nameSspace
