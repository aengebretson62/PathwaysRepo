function myCarFunction() 
{
  alert ("Get the user entered values and assigning variables to them...");
  var theMake = document.getElementById("fmake").value;
  var theModel = document.getElementById("fmodel").value;
  var theYear = document.getElementById("fyear").value;
  var theType = document.getElementById("ftype").value;

  alert ("Creating the Car object and passing the values obtained...");
  var newCar = new Car(theType,theMake, theModel, theYear);

  alert ("Providing the object information to the user");
  document.getElementById("information").innerHTML = newCar.show();
}