using System;

namespace listAbstractClass
{
    class SalaryEmployee : Employee
    {
        public double annualRate  // property
            { get; set; }


        public SalaryEmployee() : base()      // default constructor
        {
            annualRate =  0.0;
        }

        public SalaryEmployee(string newLastName, string newFirstName, string newEmployeeType, double newAnnualRate) : base (newLastName, newFirstName, newEmployeeType)       // another constructor
        {
            annualRate = newAnnualRate;
        }

        public override double GetBonus() // implementation of abstract method
        {
            return annualRate * .1;
        }

        public override string ToString()
        {
            return base.ToString() + " | Annual salary: $" + annualRate + " | Bonus: $" + GetBonus();
        }

    }  // end class

}  // end namespace