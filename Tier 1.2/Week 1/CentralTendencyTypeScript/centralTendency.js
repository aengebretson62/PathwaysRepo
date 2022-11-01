function validateANDadd() {
    // place the values in the form into letiables
    var theNewMinString = document.forms["myForm"]["minValue"].value;
    var theNewMin;
    var theNewMaxString = document.forms["myForm"]["maxValue"].value;
    var theNewMax;
    var theNewNumberString = document.forms["myForm"]["newNumber"].value;
    var theNewNumber;
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
        theNewMax = parseInt(theNewMaxString);
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
        var tableRef = document.getElementById("numberList");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewNumber;
        //calculate and display the mean
        var sum = 0; // sum will be the sum of the numbers
        var count = tableRef.rows.length; // count is the number of numbers in the table
        for (var aRow = 0; aRow < count; aRow++) { // for each row/number in the table
            sum += parseInt(((tableRef.rows[aRow]).innerHTML)); // add the number in the row in the table to the sum
        }
        var theAverage = sum / count; // calculate mean
        var labelRef1 = document.getElementById("theMean");
        labelRef1.innerHTML = theAverage.toFixed(5); // show the mean to the user
        //calculate and display the median
        // first move the numbers to an array (this will be used for the mode too)
        var theNumbers = [];
        for (var aRow = 0; aRow < count; aRow++) { // for each row/number in the table
            theNumbers.push(parseInt(((tableRef.rows[aRow]).innerHTML))); // add the number in the row in the table to the array
        }
        // next sort the array of numbers
        theNumbers.sort((function (a, b) { return a - b; }));
        var theMiddle = Math.trunc(count / 2);
        // finally show the median to the user both for an even and odd number of numbers
        if (count % 2 == 1) { // it is an odd number of items so take the number in the middle of the array
            var theNewMedian = theNumbers[theMiddle]; // find the median
            var labelRef1_1 = document.getElementById("theMedian");
            labelRef1_1.innerHTML = theNewMedian.toFixed(5); // show the median to the user
        }
        else { // it is an even number of items so take the average of the middle two
            var theNewMedian = (theNumbers[theMiddle - 1] + theNumbers[theMiddle]) / 2; // calculate the median
            var labelRef1_2 = document.getElementById("theMedian");
            labelRef1_2.innerHTML = theNewMedian.toFixed(5); // show the median to the user
        }
        //calculate and display the mode (from jonlabelle.com)
        var modes = []; // an array to hold the mode(s)
        var aCount = []; // an array to hold the count of each element in array theNumbers at the index of the number in array theNumbers
        var number = void 0; // variable to hold the current value in theNumbers being used
        var maxCount = 0; // will hold the maximum times a value is found
        for (var aRow = 0; aRow < theNumbers.length; aRow++) {
            number = theNumbers[aRow];
            aCount[number] = (aCount[number] || 0) + 1;
            if (aCount[number] > maxCount) {
                maxCount = aCount[number];
            }
        }
        for (var aRow in count)
            if (count.hasOwnProperty(aRow)) {
                if (count[aRow] === maxCount) {
                    modes.push(Number(aRow));
                }
            }
        labelRef1 = document.getElementById("theMode");
        labelRef1.innerHTML = modes; // show the mode to the user
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
    var tableRef = document.getElementById("numberList");
    tableRef.innerHTML = "";
    // clear the mean, median and mode labels
    var labelRef1 = document.getElementById("theMean");
    labelRef1.innerHTML = "n/a";
    var labelRef2 = document.getElementById("theMedian");
    labelRef2.innerHTML = "n/a";
    var labelRef3 = document.getElementById("theMode");
    labelRef3.innerHTML = "n/a";
    // clear the minValue, maxValue and newNumber text boxes
    //     in the form and enable the minValue and maxValue
    document.forms["myForm"]["minValue"].value = "";
    document.forms["myForm"]["minValue"].disabled = false;
    document.forms["myForm"]["maxValue"].value = "";
    document.forms["myForm"]["maxValue"].disabled = false;
    document.forms["myForm"]["newNumber"].value = "";
}
