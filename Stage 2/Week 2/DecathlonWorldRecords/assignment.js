async function getDecathlonWorldRecord() {
    // first build the API call string by starting with the URL
    let apiString = "https://decathlon-api.onrender.com/api/";
    // next add the parameters to the string using the drop down list
    let theEvent = document.getElementById("theEvent").value;

    apiString = apiString + theEvent

    alert(apiString);
  
    // now make the API call to the web service using the string and store what is returned in response
    let response = await fetch(apiString);
  
    // finally, print both the quote and the authoer
    document.getElementById("theDecathlonEvent").innerHTML = "";   // clear what was previously shown
    document.getElementById("theWorldRecord").innerHTML = "";   // clear what was previously shown
  
    let jsonData = await response.json();  // read the response as JSON
   
    console.log(jsonData)

    //Print out the JSON object fields after removing the quotes
    document.getElementById("theDecathlonEvent").textContent = jsonData.name;

    document.getElementById("theDecathlonWorldRecordHolder").innerHTML = jsonData.decathlonWorldRecordHolder;

    document.getElementById("theWorldRecord").innerHTML = jsonData.decathlonWorldRecord;

    //finally scroll back to the top of the page
    window.scrollTo(0,0);
  }