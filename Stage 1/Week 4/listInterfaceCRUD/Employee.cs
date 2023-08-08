using System;

namespace listInterfaceCRUD
{
    class Employee : IRate
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

       public virtual void SetRate(double newRate)  // interface method
        {
            // nothing to do here
        } 

        public virtual double GetRate()
        {
            // nothing to do here
            return -1;
        }

        public override string ToString()
        {
            return "Employee: " + lastName + ", " + firstName + " | Type: " + employeeType;
        }

    }  // end class Employee

}  //end namespace listInterface

