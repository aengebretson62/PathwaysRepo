function myFunction() {
  //  let newName: string = "";
    var newName = "Alec";
    newName = (<HTMLInputElement>document.getElementById("fname")).value;
    console.log(newName);
    document.getElementById("greeting").innerHTML = "Greetings " + newName + " !";
}

