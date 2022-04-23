using System;

namespace listAbstractClass
{
    class HourlyEmployee : Employee
    {
        public double hourlyRate  // property
            { get; set; }


        public HourlyEmployee() : base()      // default constructor
        {
            hourlyRate =  0.0;
        }

        public HourlyEmployee(string newLastName, string newFirstName, string newEmployeeType, double newHourlyRate) : base (newLastName, newFirstName, newEmployeeType)       // another constructor
        {
            hourlyRate = newHourlyRate;
        }

        public override double GetBonus() // implementation of abstract method
        {
            return hourlyRate * 80;
        }

        public override string ToString()
        {
            return base.ToString() + " | Hourly rate: $" + hourlyRate + " | Bonus: $" + GetBonus();
        }

    }  // end class

}  // end namespace