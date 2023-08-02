using System;

namespace restaurantAPP
{
  class FineDining: Restaurant
    {        

        // This is the automatic property variable.  The get and set methods are being created too.
        public bool RReservation  // property
            { get; set; }
        

        // This is the default constructor when no values are being passed.
        public FineDining () : base(null, -1)  // use the parent constructor for the name and rating
        {
            RReservation = false;
        }

        // This is the constructor when three values are passed.
        public FineDining (string newRestaurant, int newRating, bool newReservationRequired) : base(newRestaurant,newRating) // use the parent constructor for the name and rating
        {
            RReservation = newReservationRequired;
        }
        
        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return base.ToString() + " Reservation required?: " + RReservation;
        }

    }// class Restaurant
}// namespace restaurantAPP 