using System;

namespace restaurantAPP
{
  class FastFood: Restaurant
    {        

        // This is the automatic property variable.  The get and set methods are being created too.
        public bool RDriveThru  // property
            { get; set; }
        

        // This is the default constructor when no values are being passed.
        public FastFood () : base()  // use the parent constructor for the name and rating
        {
            RDriveThru = true;
        }

        // This is the constructor when three values are passed.
        public FastFood (string newRestaurant, int newRating, bool newDriveThru) : base(newRestaurant,newRating) // use the parent constructor for the name and rating
        {
            RDriveThru = newDriveThru;
        }
        
        // The following method demonstrates polymorphism.  This is the child class method that overrides the parent
        public override int tipRate()
        {
            return 0;
        }

        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return base.ToString() + " Drive thru?: " + RDriveThru;
        }



    }// class FastFood
}// namespace restaurantAPP 