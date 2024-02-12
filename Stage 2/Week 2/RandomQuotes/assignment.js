async function getAnotherQuote() {
    // first build the API call string by starting with the URL
    let apiString = "https://decathlon-api.onrender.com/api/";
    // next add the parameters to the string using the drop down list
    let theEvent = document.getElementById("theEvent").value;

    apiString = apiString + theEvent

    alert(apiString);
  
    // now make the API call to the web service using the string and store what is returned in response
    let response = await fetch(apiString);
  
    // finally, print both the quote and the authoer
    document.getElementById("theQuote").innerHTML = "";   // clear what was previously shown
    document.getElementById("theAuthor").innerHTML = "";   // clear what was previously shown
  
    let jsonData = await response.json();  // read the response as JSON
   
    console.log(jsonData)

    // stringify and print out the JSON object fields after removing the quotes
    let theNewEvent = JSON.stringify(jsonData.name);
    // theNewEvent= theNewEvent.substring(1,theNewQuote.length-1);
    document.getElementById("theQuote").innerHTML = theNewEvent;

    // let theNewAuthor = JSON.stringify(jsonData.author);
    // theNewAuthor = theNewAuthor.substring(1,theNewAuthor.length-1);
    // document.getElementById("theAuthor").innerHTML = theNewAuthor;

    //finally scroll back to the top of the page
    window.scrollTo(0,0);
  
    return true;
  }