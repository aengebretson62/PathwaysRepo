async function getAnotherQuote() {
    // first build the API call string by starting with the URL
    var apiString = "https://api.quotable.io/random";
    // next add the parameters to the string using the drop down list
    var theNewLength = document.getElementById("newLength").value;

    var minLength = 0;   
    var maxLength = 1000;
    if (theNewLength==1)  // the user wants a short one
        maxLength = 50
    else if (theNewLength==2){  // the user wants a medium one
         minLength = 50;
         maxLength = 250;}
    else // the user wants a long one
        minLength = 250;

    apiString = apiString + "?minLength=" + minLength + "&maxLength=" + maxLength;

    alert(apiString);
  
    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
  
    // finally, print both the quote and the authoer
    document.getElementById("theQuote").innerHTML = "";   // clear what was previously shown
    document.getElementById("theAuthor").innerHTML = "";   // clear what was previously shown
  
    var jsonData = await response.json();  // read the response as JSON
   
    // stringify and print out the JSON object fields after removing the quotes
    var theNewQuote = JSON.stringify(jsonData.content);
    theNewQuote = theNewQuote.substring(1,theNewQuote.length-1);
    document.getElementById("theQuote").innerHTML = theNewQuote;
    var theNewAuthor = JSON.stringify(jsonData.author);
    theNewAuthor = theNewAuthor.substring(1,theNewAuthor.length-1);
    document.getElementById("theAuthor").innerHTML = theNewAuthor;

    //finally scroll back to the top of the page
    window.scrollTo(0,0);
  
    return true;
  }