using System;

namespace MyApplication
{
  class Car
  {
    private string color;
    private string model;
    
      // Create one class constructor for the Car class that defaults to Mustang if not parameter is specified
  public Car()
  {
    color = "unassigned color";     // Set the initial value for model
    model = "unassigned model"; // Set the initial value for model
  }

    // Create a class constructor for the Car class that assigns a value passed to the constructor
  public Car(string newColor, string newModel)
  {
    color = newColor; // set the initial value for color
    model = newModel; // Set the initial value for model
  }
    
    public string getColor(){
    	return color;
    }

    public string getModel(){
    	return model;
    }
    
    public void setColor(string newColor){
       color = newColor;
    }

    public void setModel(string newModel){
       model = newModel;
    }
  }
}
