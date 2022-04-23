using System;

namespace listInterface
{
    class Employee
    {
        public string lastName  // property
            { get; set; }

        public string firstName  // property
            { get; set; }

        public string employeeType  //property
            { get; set; }    


        public Employee()       // default constructor
        {
            lastName = "";
            firstName = "";
            employeeType = "";
        }

        public Employee(string newLastName, string newFirstName, string newEmployeeType)       // another constructor
        {
            lastName = newLastName;
            firstName = newFirstName;
            employeeType = newEmployeeType;
        }

        public override string ToString()
        {
            return "Employee: " + lastName + ", " + firstName + " | Type: " + employeeType;
        }

    }  // end class Employee

}  //end namespace listInterface

