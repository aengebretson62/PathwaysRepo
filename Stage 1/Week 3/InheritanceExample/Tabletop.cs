using System;

namespace RectangleApplication {

   class Tabletop : Rectangle {
      
      // member property
      public double cost
        {get; set;}
      
      // constructor that also uses the parent (base) constructor
      public Tabletop(double l, double w) : base(l, w) 
      {
         cost = 0;
       }
      
      // method to calcuate cost assuming $70 per square unit
      public double GetCost() {
         double cost;
         cost = base.GetArea() * 70;
         return cost;
      }
      // method to display the information
      public void Display() {
         base.Display();
         Console.WriteLine("Cost: {0}", GetCost());
      }

        // an alternative to displaying the information
        public override string ToString()
        {
            return  base.ToString() + " Cost: " + GetCost();
        }
   }
}