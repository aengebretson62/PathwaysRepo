using System;
using System.Collections.Generic;   // needed for Lists

namespace listAbstractClass
{
  class Program
  {
    static void Main(string[] args)
    {

        // Create a list of Employees
        List<Employee> employeeList = new List<Employee>();
        // Add an hourly employee
        employeeList.Add(new HourlyEmployee("Enge", "J.S.", "H", 25.00));
        // Add a salary employee
        employeeList.Add(new SalaryEmployee("Enge", "Alec", "S", 15000));
        // Add an employee? - Nope
        // employeeList.Add(new Employee("Test", "test", "test"));

        // Create a list of Hourly Employees
        List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();  
        // And, create a list of Salary Employees to test
        List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();  

        // Add a couple of hourly employees to the hourly list to test
        hourlyEmployeeList.Add(new HourlyEmployee ("Enge", "Colin", "H", 15.75));
        hourlyEmployeeList.Add(new HourlyEmployee ("Enge", "Elle", "H", 25.73));

        // Add a couple of salary employees to the salary list to test
        salaryEmployeeList.Add(new SalaryEmployee ("Enge", "Anthony", "S", 45250));
        salaryEmployeeList.Add(new SalaryEmployee ("Enge", "Molly", "S", 60000));

        // Print the employee list
        foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }  // end foreach  

        // Print the hourly list
        foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
        {
            Console.WriteLine(anEmployee);
        }  // end foreach  

        // Print the salary list
        foreach (SalaryEmployee anEmployee in salaryEmployeeList)
        {
            Console.WriteLine(anEmployee);
        }  // end foreach          

    } // end Main

  }  // end class Program

}  // end nameSspace
