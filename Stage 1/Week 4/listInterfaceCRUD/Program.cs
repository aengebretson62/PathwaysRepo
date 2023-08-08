using System;
using System.Collections.Generic;   // needed for Lists

namespace listInterfaceCRUD
{
  class Program
  {
    static void Main(string[] args)
    { 

        // Create a list of Employees
        List<Employee> employeeList = new List<Employee>();

        // Add a couple of employees to the list to test
        employeeList.Add(new Employee ("Enge1", "Alec", "H"));
        employeeList.Add(new Employee ("Enge2", "J.S.", "S"));    

        // Add a couple of hourly employees to the list to test
        employeeList.Add(new HourlyEmployee ("Enge3", "Colin", "H", 15.75));
        employeeList.Add(new HourlyEmployee ("Enge4", "Elle", "H", 25.73));    

        // Add a couple of salary employees to the list to test
        employeeList.Add(new SalaryEmployee ("Enge5", "Anthony", "S", 45250));
        employeeList.Add(new SalaryEmployee ("Enge6", "Molly", "S", 60000)); 

        // Print the list
        foreach (Employee anEmployee in employeeList)
        {
            Console.WriteLine(anEmployee);
            Console.WriteLine("And that rate again..." + anEmployee.GetRate());
        }  // end foreach  


        // Experiment with Reading (finding) an employee(s) in the list
        //======================================================================
        Console.Write("Please enter an employee last name to find: ");
        string findName = Console.ReadLine();
        bool found = false;
        foreach (Employee anEmployee in employeeList)
        {
            if (anEmployee.lastName == findName)
            {
                Console.WriteLine(anEmployee);
                found = true;
            }
        }  // end foreach  
        if (!(found))
            Console.WriteLine("Name was not found.");
        //==========================================================================
            
        // Experiment with Creating (adding) an employee to the list
        //======================================================================
        Console.Write("Please enter an employee last name to add: ");
        string newLastName = Console.ReadLine();
        Console.Write("Please enter an employee first name to add: ");
        string newFirstName = Console.ReadLine();
        Console.Write("Please enter an employee type to add (S or H): ");
        string newEmployeeType = Console.ReadLine();
        switch (newEmployeeType)
        {
            case "S":
            case "s":
                Console.Write("Please enter an annual salary: ");
                double newEmployeeSalary = Convert.ToDouble(Console.ReadLine());
                employeeList.Add(new SalaryEmployee(newLastName, newFirstName, newEmployeeType, newEmployeeSalary));
                Console.WriteLine("Salary employee added.  Printing out new list.");
            break;
            case "H":
            case "h":
                Console.Write("Please enter an hourly salary: ");
                double newEmployeeHourly = Convert.ToDouble(Console.ReadLine());
                employeeList.Add(new HourlyEmployee(newLastName, newFirstName, newEmployeeType, newEmployeeHourly));
                Console.WriteLine("Salary employee added.  Printing out new list.");            
            break;
            default:
                Console.WriteLine("Oops, wrong option and you only get one chance here! Nothing was added.");
            break;
        }
        // print the list again
        foreach (Employee anEmployee in employeeList)
                Console.WriteLine(anEmployee);
 
        //==========================================================================   

        // Experiment with deleting an employee in the list
        //======================================================================
        Console.Write("Please enter an employee last name to delete: ");
        string findLastName = Console.ReadLine();
        Console.Write("Please enter an employee first name to delete: ");
        string findFirstName = Console.ReadLine();
        found = false;
        for (int index = 0; index < employeeList.Count; index++)
        {
            if ((employeeList[index].lastName == findLastName) && (employeeList[index].firstName == findFirstName))
            {
                employeeList.RemoveAt(index);
                found = true;
            }
        }  // end foreach  
        if (found)
            Console.WriteLine("Employee was deleted.  I hope that is what you wanted!");
        else
            Console.WriteLine("Employee not found.  No one was deleted.");
        // print the list again
        foreach (Employee anEmployee in employeeList)
                Console.WriteLine(anEmployee);
 
        //==========================================================================

        // Experiment with updating an employee's hourly rate or salary in the list
        //======================================================================
        Console.Write("Please enter an employee last name to update: ");
        findLastName = Console.ReadLine();
        Console.Write("Please enter an employee first name to update: ");
        findFirstName = Console.ReadLine();
        found = false;
        for (int index = 0; index < employeeList.Count; index++)
        {
            if ((employeeList[index].lastName == findLastName) && (employeeList[index].firstName == findFirstName))
            {
                Console.Write("Employee found!  Please enter the new amount:");
                double newAmount = Convert.ToDouble(Console.ReadLine());
                employeeList[index].SetRate(newAmount);
                found = true;
            }
        }  // end for
        if (found)
            Console.WriteLine("Employee was updated.  I hope that is what you wanted!");
        else
            Console.WriteLine("Employee not found.  No one was updated.");
        // print the list again
        foreach (Employee anEmployee in employeeList)
                Console.WriteLine(anEmployee);
        //==========================================================================         

    } // end Main

  }  // end class Program

}  // end nameSspace
