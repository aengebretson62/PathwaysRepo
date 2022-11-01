function validateANDadd() {
    // place the values in the form into variables
    var theNewWord = document.forms["myForm"]["newWord"].value;
    var theNewNumber = document.forms["myForm"]["newNumber"].value;
    // validate that something was entered as a word
    if (theNewWord == "") {
      // no word was entered so tell the user
      alert("Please enter a word to check");
      return false;
    }
    // validate that a 1 or 2 was entered as a number
    else if ((theNewNumber != 1) && (theNewNumber != 2)) {
      // a 1 or 2 was not entered as the number so tell user and clear the field
      alert("Please enter a 1 or 2 for the list.");
      document.forms["myForm"]["newNumber"].value = "";
      return false;
    }
    else {
        // a word was entered and a 1 or 2 was entered as the number 
        // so add the word to the proper table 
        if (theNewNumber==1){
           var tableRef = document.getElementById("myList1");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ': ' + PalindromeCheck1(theNewWord);}
        else {
           var tableRef = document.getElementById("myList2");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ': ' + PalindromeCheck2(theNewWord);;}
        // erase the form fields
        document.forms["myForm"]["newWord"].value = "";
        document.forms["myForm"]["newNumber"].value = "";
        return true;
    }
  }

  function clearList1() {
    // clear the table of all rows
    var tableRef = document.getElementById("myList1");
    tableRef.innerHTML = " ";
  }

  function clearList2() {
    // clear the table of all rows
    var tableRef = document.getElementById("myList2");
    tableRef.innerHTML = " ";
  }

  function PalindromeCheck1 (theword){
    // This algorithm creates a string that is the reverse 
    //   of the original string and then compares the strings 

    // create a string the reverse of the original
        // Step 1. Use the split() method to return a new array of characters
        // Step 2. Use the reverse() method to reverse the new created array
        // Step 3. Use the join() method to join all elements of the array into a string
    var reverseword = theword.split("").reverse().join("");  // thank you freecodecamp.com
    // compare them using the ===
    return theword === reverseword;
  }

  function PalindromeCheck2 (theword){
    // This algorithm uses iteration to loop through the first half of the string
    //   and compare each character with the appropriate character in the second half of the string

    // assume it is a palindrome...
    var palindrome = true;

    var middle = theword.length / 2;
    for (i=0; i <=  middle; i++){
      if (theword[i] != theword[theword.length - i - 1])
            palindrome = false; 
    } 
    return palindrome;
  }