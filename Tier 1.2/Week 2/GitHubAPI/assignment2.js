async function getAnotherUser() {

    // first build the API call string by starting with the URL
    var apiString = "https://api.github.com/users";
    // next add the user parameter to the string using the textbox and add / repos to the string
    var theNewUser = document.getElementById('newUser').value;
    apiString = apiString + "/" + theNewUser + "/repos";

    // make the API call to the web service using the string 
    var response = await fetch(apiString)

    // now, check the status property of the response object, 200-299 is valid
    if (response.status >= 200 && response.status <= 299) {  // valid status

      var jsonData = await response.json();   // a json file will fetched

      // create the user feedback with the repos and links
      var theNewRepos = "";
      for (var aRepos in jsonData) {
            theNewRepos += "<p><a href=" + jsonData[aRepos].html_url + ">" + jsonData[aRepos].name + "</a></p>";
          }

    } else {            // invalid status
      // Handle errors
        theNewRepos = "<p>Error accessing GitHub, status: " + response.status + ": " + response.statusText;
        console.log(response.status, response.statusText);
    }

    // print both the quote and the authoer
    document.getElementById("theUserName").innerHTML = "";   // clear what was previously shown
    document.getElementById("theRepos").innerHTML = "";   // clear what was previously shown
    // print out the information for the user and clear the userid
    document.getElementById("theUserName").innerHTML = theNewUser;
    document.getElementById("theRepos").innerHTML = theNewRepos;
    document.getElementById('newUser').value = "";

    //finally scroll back to the top of the page
    window.scrollTo(0,0);
  
    return true;
  }