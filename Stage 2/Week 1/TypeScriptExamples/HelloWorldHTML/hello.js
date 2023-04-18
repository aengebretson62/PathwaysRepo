function myFunction() {
    var newName = "";
    newName = document.getElementById("fname").value;
    document.getElementById("greeting").innerHTML = "And yet more Greetings " + newName + " !";
}
