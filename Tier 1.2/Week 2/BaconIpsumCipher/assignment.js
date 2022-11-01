async function getBaconipsum() {
  // first build the API call string by starting with the URL
  var apiString = "https://baconipsum.com/api/";
  // next add the parameters to the string using the drop down lists
  var theNewType = document.getElementById("newType").value;
  var theNewParagraphs = document.getElementById("newParagraphs").value;
  apiString = apiString + "?type=" + theNewType + "&paras=" + theNewParagraphs;
  alert(apiString);  // show the API string

  // now make the API call to the web service using the string and store what is returned in response
  var response =  await fetch(apiString);

  // finally, print the response in the various formats
  document.getElementById("myRawData").innerHTML = "";   // clear what was previously shown
  document.getElementById("myFormattedData").innerHTML = "";   // clear what was previously shown
  document.getElementById("myEncryptedData").innerHTML = "";   // clear what was previously shown

  var jsonData =  await response.json();  // read the response as JSON
  
  // stringify and print out the JSON object in the RawData section
  document.getElementById("myRawData").innerHTML = JSON.stringify(jsonData);
 
  // loop through the JSON object one paragraph at a time and print each in the FormattedData section
  for (var para in jsonData) {   
      document.getElementById("myFormattedData").innerHTML += "<p>" + jsonData[para] + "</p>";
    }

  // determine which algorithm to use, encrypt the data using that algorithm, and print in the myEncryptedData section
  var theNewFormat = document.getElementById("newFormat").value;  
  var newJsonData;
  if (theNewFormat === "1")
      newJsonData = cipher1(jsonData);   // apply the first cipher algorithm
  else
      newJsonData = cipher2(jsonData);   // apply the second cipher algorithm

  // loop through the encrypted JSON object one paragraph at a time and print each in the EncryptedData section
  for (var para in newJsonData) {   
    document.getElementById("myEncryptedData").innerHTML += "<p>" + newJsonData[para] + "</p>";
  }

  return true;
}

function cipher1 (someJSON) {
    /* This simple Caesar's cipher algorithm will add 13 to the ASCII value of each character if the character
       is a letter.  It is circular so when adding 13 if it goes past z (or Z) it will go to a (or A) next. */

       var newChar;      // will contain the character being examined
       var newCharCode;  // will contain the ASCII code of the character being examined
       var newJSON=[];   // will contain the new JSON, initially an empty array

    // loop through the JSON object one paragraph at a time
    for (var para in someJSON) {     // for each paragraph in the object
      var newPara = "";              // initialize new paragraph to empty string, build it one character at a time
      for (var chara in someJSON[para]){          // for each character in the paragraph
        newChar = someJSON[para][chara];          //     get the character
        newCharCode = newChar.charCodeAt(0);      //     get the ASCII code of the character
        if ((newCharCode >= 65)&&(newCharCode <= 77))           // check for A-M
          newChar = String.fromCharCode(newCharCode+13)              // change the character
        else if ((newCharCode >= 78)&&(newCharCode <= 90))      // check for N-Z
          newChar = String.fromCharCode(newCharCode-13)              // change the character
        else if ((newCharCode >= 97)&&(newCharCode <= 109))     // check for a-m
          newChar = String.fromCharCode(newCharCode+13)              // change the character
        else if ((newCharCode >= 110)&&(newCharCode <= 122))    // check for n-z
          newChar = String.fromCharCode(newCharCode-13);             // change the character
        newPara += newChar;          // add the new character to the paragraph
      }  // end for each character

    newJSON.push(newPara);   // add the new encrypted paragraph array

    }  // end for each paragraph

  return newJSON;   // return the encrypted paragraphs
}

function cipher2 (someJSON) {
  /* This simple Caesar's cipher algorithm will simply add 1 to every character in an even position
     in a paragraph and subtract 1 from every character in an odd position in a paragraph. */

     var newChar;      // will contain the character being examined
     var newCharCode;  // will contain the ASCII code of the character being examined
     var newJSON=[];   // will contain the new JSON, initially an empty array

  // loop through the JSON object one paragraph at a time
  for (var para in someJSON) {     // for each paragraph in the object
    var newPara = "";              // initialize new paragraph to empty string, build it one character at a time
    var charPos = 0;               // this will keep track of even and odd positions and toggle with each character
    for (var chara in someJSON[para]){          // for each character in the paragraph
      newChar = someJSON[para][chara];          //     get the character
      newCharCode = newChar.charCodeAt(0);      //     get the ASCII code of the character
      if (charPos === 0){                        //     check if even or odd position
        newChar = String.fromCharCode(newCharCode+1)      //  it's even so add 1
        charPos = 1;                                      //  toggle to odd
      }       
      else{                        
        newChar = String.fromCharCode(newCharCode-1)      //  it's odd so subtract 1
        charPos = 0;                                      //  toggle to even
      }       
    newPara += newChar;          // add the new character to the paragraph
    }  // end for each character

  newJSON.push(newPara);   // add the new encrypted paragraph array

  }  // end for each paragraph

return newJSON;   // return the encrypted paragraphs
}