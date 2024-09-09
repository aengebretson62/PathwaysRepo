function myFunction() {
    var newName = " ";
    newName = document.getElementById("fname").value;
    console.log(newName);
    document.getElementById("greeting").innerHTML = "More splendid greetings " + newName + " !!";
}
