async function getForecast(){
  
  var ApiString = "https://api.weather.gov/gridpoints/";
  var theNewOffice = document.getElementById("newOffice").value;
  ApiString = ApiString + theNewOffice + "/31,80/forecast";

  console.log(ApiString);

  var response = await fetch(ApiString);
  var jsonData = await response.json();

  days=jsonData.properties.periods.length;

  document.getElementById("myDays").innerHTML = "";
  document.getElementById("myWeather").innerHTML = "";
  document.getElementById("myTemp").innerHTML = "";
  
  for (let i=0;i<days;i++){
    document.getElementById("myDays").innerHTML += jsonData.properties.periods[i].name + "<br><br>";
    document.getElementById("myWeather").innerHTML += jsonData.properties.periods[i].shortForecast + "<br><br>";
    document.getElementById("myTemp").innerHTML += jsonData.properties.periods[i].temperature + " degrees Farenheit" + "<br><br>";
  }

}