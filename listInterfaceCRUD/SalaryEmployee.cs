using System;

namespace listInterfaceCRUD
{
    class SalaryEmployee : Employee, IGetBonus, IRate
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

        public double GetBonus() // interface method
        {
            return annualRate * .1;
        }


        public override void SetRate(double newRate)  // interface method
        {
            annualRate = newRate;
        }

        public override string ToString()
        {
            return base.ToString() + " | Annual salary: $" + annualRate + " | Bonus: $" + GetBonus();
        }

    }  // end class

}  // end namespace