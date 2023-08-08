using System;

namespace listInterfaceCRUD
{
    class HourlyEmployee : Employee, IGetBonus
    {
        public double hourlyRate  // property
            { get; set; }


        public HourlyEmployee() : base()      // default constructor
        {
            hourlyRate =  0.0;
        }

        public HourlyEmployee(string newLastName, string newFirstName, string newEmployeeType, double newHourlyRate) : base (newLastName, newFirstName, newEmployeeType)       // another constructor
        {
            SetRate(newHourlyRate);
        }

        public double GetBonus() // interface method
        {
            return hourlyRate * 80;
        }

        public override void SetRate(double newRate)  // interface method
        {
            hourlyRate = newRate;
        }

        public override double GetRate()
        {
            return hourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + " | Hourly rate: $" + hourlyRate + " | Bonus: $" + GetBonus();
        }

    }  // end class

}  // end namespace