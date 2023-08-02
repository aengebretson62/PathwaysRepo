using System;

namespace restaurantAPP
{
  class Restaurant
    {        
        // Two pieces of data are being stored for each object.  
        // RName is the restaurant name.  To show the difference in how values can be stored,
        // RName will be an instance variable.
        // RRating is the restaurant rating.  To show the difference in how values can be stored,
        // RRating will be an automatic property.

        // This is the instance variable so it must be declared.  It's private so only methods of the 
        // object can access it.
        private string RName;  // restaurant name

        // This is the automatic property variable.  The get and set methods are being created too.
        public int RRating  // property
            { get; set; }
        

        // This is the default constructor when no values are being passed.
        public Restaurant ()
        {
            RName = null;
            RRating = -1;
        }

        // This is the constructor when two values are passed.
        public Restaurant (string newRestaurant, int newRating)
        {
            RName = newRestaurant;
            RRating = newRating;
        }
        
        //  Since RName is not defined as a property, we need to create the get and set mehtods
        //  for it.
        public string getName()
        {
            return RName; 
        }  

        public void setName (string newName)
        {
            RName = newName;
        }


        // This overrides ToString so an object can be printed out with the WriteLine.

        public override string ToString()
        {
            return "Restaurant: " + RName + ":  Rating: " + RRating;
        }

    }// class Restaurant
}// namespace restaurantAPP 