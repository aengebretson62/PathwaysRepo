function validateANDadd() {

    // place the values in the form into letiables
    let theNewMinString: string = document.forms["myForm"]["minValue"].value;
    let theNewMin: number;
    let theNewMaxString: string = document.forms["myForm"]["maxValue"].value;
    let theNewMax: number;
    let theNewNumberString: string = document.forms["myForm"]["newNumber"].value;
    let theNewNumber: number

    // validate that something was entered for minimum
    if (theNewMinString == "") {
      // nothing was entered so tell the user
      alert("Please enter the minimum value");
      return false;
    }
    else
      theNewMin = parseInt(theNewMinString);   

    // validate that something was entered for maximum
    if (theNewMaxString == "") {
        // nothing was entered so tell the user
          alert("Please enter a maximum value");
          return false;
    } 
    else
      theNewMax = parseInt(theNewMaxString)

    // validate that the maximum is greater than the minimum 
    if (theNewMax <= theNewMin) {
      // a minimum larger than the maximum was entered so tell the user
      alert("The maximum value must be larger than the minimum.");
      return false;
    }

    // validate that something was entered for the number
    if (theNewNumberString == "") {
      // nothing was entered so tell the user
      alert("Please enter a number to add to the list");
      return false;
      }
    else
      theNewNumber = parseInt(theNewNumberString);

    // validate that the number entered in in the range
    if ((theNewNumber < theNewMin) || (theNewNumber > theNewMax)) {
      // the number was not in the range so tell the user
      alert("Please enter a value in the range");
      document.forms["myForm"]["newNumber"].value = "";
      return false;
      }
      else {
        // valid numbers are entered for the range and the number

        // so first add the number to the list 
        let tableRef = document.getElementById("numberList");
        (tableRef.insertRow(tableRef!.rows.length)).innerHTML = theNewNumber;

        //calculate and display the mean
        let sum = 0;    // sum will be the sum of the numbers
        let count = tableRef.rows.length   // count is the number of numbers in the table
        for (let aRow: number = 0; aRow < count; aRow++){     // for each row/number in the table
          sum += parseInt(((tableRef.rows[aRow]).innerHTML));  // add the number in the row in the table to the sum
        }
        let theAverage: number = sum/count;     // calculate mean
        let labelRef1 = document.getElementById("theMean");    
        labelRef1.innerHTML = theAverage.toFixed(5);   // show the mean to the user

        //calculate and display the median
        // first move the numbers to an array (this will be used for the mode too)
        let theNumbers = [];
        for (let aRow: number = 0; aRow < count; aRow++){     // for each row/number in the table
          theNumbers.push(parseInt(((tableRef.rows[aRow]).innerHTML)));  // add the number in the row in the table to the array
        }
        // next sort the array of numbers
        theNumbers.sort((function(a, b){return a - b}));
        let theMiddle: number = Math.trunc(count/2);
        // finally show the median to the user both for an even and odd number of numbers
        if (count%2==1){       // it is an odd number of items so take the number in the middle of the array
          let theNewMedian: number = theNumbers[theMiddle];     // find the median
          let labelRef1 = document.getElementById("theMedian");    
          labelRef1.innerHTML = theNewMedian.toFixed(5);   // show the median to the user
        }
        else{                  // it is an even number of items so take the average of the middle two
          let theNewMedian: number = (theNumbers[theMiddle-1] + theNumbers[theMiddle])/2;     // calculate the median
          let labelRef1 = document.getElementById("theMedian");    
          labelRef1.innerHTML = theNewMedian.toFixed(5);   // show the median to the user
        }

        //calculate and display the mode (from jonlabelle.com)

        let modes: number[] = [];  // an array to hold the mode(s)
        let aCount: number[] = [];  // an array to hold the count of each element in array theNumbers at the index of the number in array theNumbers
        let number: number;      // variable to hold the current value in theNumbers being used
        let maxCount: number = 0;  // will hold the maximum times a value is found
 
        for (let aRow: number = 0; aRow < theNumbers.length; aRow++) {
            number = theNumbers[aRow];
            aCount[number] = (aCount[number] || 0) + 1;
            if (aCount[number] > maxCount) {
                maxCount = aCount[number];
            }
        }
     
        for (let aRow in count)
            if (count.hasOwnProperty(aRow)) {
                if (count[aRow] === maxCount) {
                    modes.push(Number(aRow));
                }
            }

        labelRef1 = document.getElementById("theMode");    
        (labelRef1!.innerHTML as any) = modes;   // show the mode to the user
          
        // erase the number in the form
        document.forms["myForm"]["newNumber"].value = "";

        // disable the min and max range so the range can't change
        document.forms["myForm"]["minValue"].disabled = true;
        document.forms["myForm"]["maxValue"].disabled = true;

        return true;
    }
  }

  function clearAll() {
    // clear the table
    let tableRef = document.getElementById("numberList");
    tableRef!.innerHTML = "";
    // clear the mean, median and mode labels
    let labelRef1 = document.getElementById("theMean");
    labelRef1!.innerHTML = "n/a";
    let labelRef2 = document.getElementById("theMedian");
    labelRef2!.innerHTML = "n/a";
    let labelRef3 = document.getElementById("theMode");
    labelRef3!.innerHTML = "n/a";
    // clear the minValue, maxValue and newNumber text boxes
    //     in the form and enable the minValue and maxValue
    document.forms["myForm"]["minValue"].value = "";
    document.forms["myForm"]["minValue"].disabled = false;
    document.forms["myForm"]["maxValue"].value = "";
    document.forms["myForm"]["maxValue"].disabled = false;
    document.forms["myForm"]["newNumber"].value = "";

  }
