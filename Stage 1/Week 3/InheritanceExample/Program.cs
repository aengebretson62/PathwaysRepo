using System;

namespace RectangleApplication {

   class ExecuteRectangle {
      static void Main(string[] args) {
         Tabletop t = new Tabletop(4.5, 7.5);
         t.Display();  //output with the Display method
         Console.WriteLine(t); //output with the overide of ToString
         Console.ReadLine();
         Rectangle r = new Rectangle(5, 10);
         r.Display();  //output with the Display method
         Console.WriteLine(r); //output with the overide of ToString
      }
   }
}
