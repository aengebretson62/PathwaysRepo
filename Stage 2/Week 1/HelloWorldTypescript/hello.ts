function myFunction() {
    let newName: string = " ";
    newName = (<HTMLInputElement>document.getElementById("fname")).value;
    console.log(newName);
    document.getElementById("greeting").innerHTML = "Greetings " + newName + " !!";
}

