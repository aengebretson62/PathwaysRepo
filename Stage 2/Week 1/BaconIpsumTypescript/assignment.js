var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
function getBaconipsum() {
    return __awaiter(this, void 0, void 0, function () {
        var apiString, theNewType, theNewParagraphs, response, jsonData, para, theNewFormat, newJsonData, para;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiString = "https://baconipsum.com/api/";
                    theNewType = document.getElementById("newType").value;
                    theNewParagraphs = document.getElementById("newParagraphs").value;
                    apiString = apiString + ("?type=" + theNewType + "&paras=" + theNewParagraphs);
                    alert(apiString); // show the API string
                    return [4 /*yield*/, fetch(apiString)];
                case 1:
                    response = _a.sent();
                    // finally, print the response in the various formats
                    document.getElementById("myRawData").innerHTML = ""; // clear what was previously shown
                    document.getElementById("myFormattedData").innerHTML = ""; // clear what was previously shown
                    document.getElementById("myEncryptedData").innerHTML = ""; // clear what was previously shown
                    return [4 /*yield*/, response.json()];
                case 2:
                    jsonData = _a.sent();
                    // stringify and print out the JSON object in the RawData section
                    document.getElementById("myRawData").innerHTML = JSON.stringify(jsonData);
                    // loop through the JSON object one paragraph at a time and print each in the FormattedData section
                    for (para in jsonData) {
                        document.getElementById("myFormattedData").innerHTML += "<p> " + jsonData[para] + " </p>";
                    }
                    theNewFormat = document.getElementById("newFormat").value;
                    if (theNewFormat === "1")
                        newJsonData = cipher1(jsonData); // apply the first cipher algorithm
                    else
                        newJsonData = cipher2(jsonData); // apply the second cipher algorithm
                    // loop through the encrypted JSON object one paragraph at a time and print each in the EncryptedData section
                    for (para in newJsonData) {
                        document.getElementById("myEncryptedData").innerHTML += "<p>" + newJsonData[para] + "</p>";
                    }
                    return [2 /*return*/, true];
            }
        });
    });
}
function cipher1(someJSON) {
    /* This simple Caesar's cipher algorithm will add 13 to the ASCII value of each character if the character
       is a letter.  It is circular so when adding 13 if it goes past z (or Z) it will go to a (or A) next. */
    var newChar; // will contain the character being examined
    var newCharCode; // will contain the ASCII code of the character being examined
    var newJSON = [String]; // will contain the new JSON, initially an empty array
    // loop through the JSON object one paragraph at a time
    for (var para in someJSON) { // for each paragraph in the object
        var newPara = ""; // initialize new paragraph to empty string, build it one character at a time
        for (var chara in someJSON[para]) { // for each character in the paragraph
            newChar = someJSON[para][chara]; //     get the character
            newCharCode = newChar.charCodeAt(0); //     get the ASCII code of the character
            if ((newCharCode >= 65) && (newCharCode <= 77)) // check for A-M
                newChar = String.fromCharCode(newCharCode + 13); // change the character
            else if ((newCharCode >= 78) && (newCharCode <= 90)) // check for N-Z
                newChar = String.fromCharCode(newCharCode - 13); // change the character
            else if ((newCharCode >= 97) && (newCharCode <= 109)) // check for a-m
                newChar = String.fromCharCode(newCharCode + 13); // change the character
            else if ((newCharCode >= 110) && (newCharCode <= 122)) // check for n-z
                newChar = String.fromCharCode(newCharCode - 13); // change the character
            newPara += newChar; // add the new character to the paragraph
        } // end for each character
        newJSON.push(newPara); // add the new encrypted paragraph array
    } // end for each paragraph
    return newJSON; // return the encrypted paragraphs
}
function cipher2(someJSON) {
    /* This simple Caesar's cipher algorithm will simply add 1 to every character in an even position
       in a paragraph and subtract 1 from every character in an odd position in a paragraph. */
    var newChar; // will contain the character being examined
    var newCharCode; // will contain the ASCII code of the character being examined
    var newJSON = [String]; // will contain the new JSON, initially an empty array
    // loop through the JSON object one paragraph at a time
    for (var para in someJSON) { // for each paragraph in the object
        var newPara = ""; // initialize new paragraph to empty string, build it one character at a time
        var charPos = 0; // this will keep track of even and odd positions and toggle with each character
        for (var chara in someJSON[para]) { // for each character in the paragraph
            newChar = someJSON[para][chara]; //     get the character
            newCharCode = newChar.charCodeAt(0); //     get the ASCII code of the character
            if (charPos === 0) { //     check if even or odd position
                newChar = String.fromCharCode(newCharCode + 1); //  it's even so add 1
                charPos = 1; //  toggle to odd
            }
            else {
                newChar = String.fromCharCode(newCharCode - 1); //  it's odd so subtract 1
                charPos = 0; //  toggle to even
            }
            newPara += newChar; // add the new character to the paragraph
        } // end for each character
        newJSON.push(newPara); // add the new encrypted paragraph array
    } // end for each paragraph
    return newJSON; // return the encrypted paragraphs
}
