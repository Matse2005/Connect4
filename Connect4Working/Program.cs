using Connect4.Models;
using Connect4.Views;
using Connect4.Controllers;

/*
 * Load the views
 */
BoardView boardView = new BoardView();
GameView gameView = new GameView();

/*
 * Load the controllers
 */
PlayersController playersController = new PlayersController();
BoardController boardController = new BoardController();
GameController gameController = new GameController();

/*
 * Define the again variable
 * -> The again variable will tell the game if there has to be a next move
 */
bool again = true;

/*
 * Define the players
 */
PlayersModel playerOne = new PlayersModel();
PlayersModel playerTwo = new PlayersModel();

/*
 * Define the board
 */
BoardModel boardModel = new BoardModel();

/*
 *  Request info about player one
 */
playersController.setPlayer(playerOne, Convert.ToChar("X"), 1);

/*
 *  Request info about player two
 */
playersController.setPlayer(playerTwo, Convert.ToChar("O"), 2);

/*
 * Create the board
 */
boardController.setBoard(boardModel);

/*
 *  Start the game
 */
do
{
    /*
     * Draw the board
     */
    Console.Clear();
    boardView.draw(boardModel);

    /*
    * Player 1's turn
    */
    gameController.Turn(playerOne, boardModel);

    /*
     *  Check if there is a four on a row
     */
    if (gameController.CheckFour(boardModel, playerOne))
    {
        Console.Clear();
        boardView.draw(boardModel);

        Console.WriteLine();
        gameView.Win(playerOne.playerName);
        again = false;
        return;
    }

    /*
     *  Check if the board is full
     */
    if (gameController.BoardFull(boardModel))
    {
        Console.Clear();
        boardView.draw(boardModel);

        Console.WriteLine();
        gameView.BoardFull();
        again = false;
        return;
    }

    /*
     * Draw the board
     */
    Console.Clear();
    boardView.draw(boardModel);

    /*
    * Player 2's turn
    */
    gameController.Turn(playerTwo, boardModel);

    /*
     *  Check if there is a four on a row
     */
    if (gameController.CheckFour(boardModel, playerTwo))
    {
        Console.Clear();
        boardView.draw(boardModel);

        Console.WriteLine();
        gameView.Win(playerTwo.playerName);
        again = false;
        return;
    }

    /*
     *  Check if the board is full
     */
    if (gameController.BoardFull(boardModel))
    {
        Console.Clear();
        boardView.draw(boardModel);

        Console.WriteLine();
        gameView.BoardFull();
        again = false;
        return;
    }
} while (again);