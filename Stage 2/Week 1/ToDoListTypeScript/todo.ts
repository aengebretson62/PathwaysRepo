const enterButton: HTMLButtonElement = <HTMLButtonElement>document.getElementById("enter");
const input: HTMLInputElement = <HTMLInputElement>document.getElementById("userInput");
const ul: HTMLUListElement = <HTMLUListElement>document.querySelector("ul");
const item: HTMLCollectionOf<HTMLLIElement> = <HTMLCollectionOf<HTMLLIElement>>document.getElementsByTagName("li");

function inputLength(): number {
	return input.value.length;
} 

function listLength(): number {
	return item.length;
}

function createListElement() {
	const li: HTMLLIElement = <HTMLLIElement>document.createElement("li"); //  creates an element "li"

	li.appendChild(document.createTextNode(input.value)); //makes text from input field the li text

	ul.appendChild(li); //adds li to ul
	input.value = ""; //Reset text input field

	//START STRIKETHROUGH
	// because it's in the function, it only adds it for new items
	function crossOut() {
		li.classList.toggle("done");
	}
	li.addEventListener("click",crossOut);
	//END STRIKETHROUGH

	// START ADD DELETE BUTTON
	const dBtn: HTMLButtonElement = <HTMLButtonElement>document.createElement("button");
	dBtn.appendChild(document.createTextNode("X"));
	li.appendChild(dBtn);
	dBtn.addEventListener("click", deleteListItem);
	// END ADD DELETE BUTTON
	function deleteListItem(){
		li.classList.add("delete");
	}
	//END ADD CLASS DELETE
}


function addListAfterClick(){
	if (inputLength() > 0) { //makes sure that an empty input field doesn't create a li
		createListElement();
	}
}

function addListAfterKeypress(event) {
	if (inputLength() > 0 && event.which ===13) {  //this now looks to see if you hit "enter"/"return"
		createListElement();		               //the 13 is the enter key's keycode
	} 
}


enterButton.addEventListener("click",addListAfterClick);

input.addEventListener("keypress", addListAfterKeypress);
