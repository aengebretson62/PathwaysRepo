/*
We store our game status element here to allow us to more easily
use it later on
*/
var statusDisplay = document.querySelector('.game--status');
/*
Here we declare some variables that we will use to track the
game state throught the game.
*/
/*
We will use gameActive to pause the game in case of an end scenario
*/
var gameActive = true;
/*
We will store our current player here, so we know whos turn
*/
var currentPlayer = "X";
/*
We will store our current game state here, the form of empty strings in an array
 will allow us to easily track played cells and validate the game state later on
*/
var gameState = ["", "", "", "", "", "", "", "", ""];
/*
Here we have declared some messages we will display to the user during the game.
Since we have some dynamic factors in those messages, namely the current player,
we have declared them as functions, so that the actual message gets created with
current data every time we need it.
*/
var winningMessage = function () { return "Player " + currentPlayer + " has won!"; };
var drawMessage = function () { return "Game ended in a draw!"; };
var currentPlayerTurn = function () { return "It's " + currentPlayer + "'s turn"; };
/*
We set the inital message to let the players know whose turn it is
*/
statusDisplay.innerHTML = currentPlayerTurn();
function handleCellPlayed(clickedCell, clickedCellIndex) {
    /*
    We update our internal game state to reflect the played move,
    as well as update the user interface to reflect the played move
    */
    gameState[clickedCellIndex] = currentPlayer;
    clickedCell.innerHTML = currentPlayer;
}
function handlePlayerChange() {
    currentPlayer = currentPlayer === "X" ? "O" : "X";
    statusDisplay.innerHTML = currentPlayerTurn();
}
var winningConditions = [
    [0, 1, 2],
    [3, 4, 5],
    [6, 7, 8],
    [0, 3, 6],
    [1, 4, 7],
    [2, 5, 8],
    [0, 4, 8],
    [2, 4, 6]
];
function handleResultValidation() {
    var roundWon = false;
    for (var i = 0; i <= 7; i++) {
        var winCondition = winningConditions[i];
        var a = gameState[winCondition[0]];
        var b = gameState[winCondition[1]];
        var c = gameState[winCondition[2]];
        if (a === '' || b === '' || c === '') {
            continue;
        }
        if (a === b && b === c) {
            roundWon = true;
            break;
        }
    }
    if (roundWon) {
        statusDisplay.innerHTML = winningMessage();
        gameActive = false;
        return;
    }
    var roundDraw = 0;
    for (var i = 0; i < 9; i++) {
        if ((gameState[i] == "X") || (gameState[i] == "O"))
            roundDraw++;
    }
    if (roundDraw == 9) {
        statusDisplay.innerHTML = drawMessage();
        gameActive = false;
        return;
    }
}
function handleCellClick(clickedCellEvent) {
    /*
    We will save the clicked html element in a variable for easier further use
    */
    var clickedCell = clickedCellEvent.target;
    /*
    Here we will grab the 'data-cell-index' attribute from the clicked cell to identify where that cell is in our grid.
    Please note that the getAttribute will return a string value. Since we need an actual number we will parse it to an
    integer(number)
    */
    var clickedCellIndex = parseInt(clickedCell.getAttribute('data-cell-index'));
    /*
    Next up we need to check whether the call has already been played,
    or if the game is paused. If either of those is true we will simply ignore the click.
    */
    if (gameState[clickedCellIndex] !== "" || !gameActive) {
        return;
    }
    /*
    If everything if in order we will proceed with the game flow
    */
    else {
        handleCellPlayed(clickedCell, clickedCellIndex);
        handleResultValidation();
        if (gameActive)
            handlePlayerChange();
    }
}
function handleRestartGame() {
    gameActive = true;
    currentPlayer = "X";
    gameState = ["", "", "", "", "", "", "", "", ""];
    statusDisplay.innerHTML = currentPlayerTurn();
    document.querySelectorAll('.cell')
        .forEach(function (cell) { return cell.innerHTML = ""; });
}
/*
And finally we add our event listeners to the actual game cells, as well as our
restart button
*/
document.querySelectorAll('.cell').forEach(function (cell) { return cell.addEventListener('click', handleCellClick); });
document.querySelector('.game--restart').addEventListener('click', handleRestartGame);
