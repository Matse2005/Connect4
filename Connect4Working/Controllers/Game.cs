using Connect4.Models;
using Connect4.Views;

namespace Connect4.Controllers
{
    internal class GameController
    {
        GameView gameView = new GameView();

        public void Turn(PlayersModel player, BoardModel boardModel)
        {
            int column;

            do
            {
                column = VerifyNumber(player, boardModel);
            } while (ColumnFull(boardModel, column));

            SetTurn(player, boardModel, column);

            return;
        }

        public int VerifyNumber(PlayersModel player, BoardModel boardModel)
        {
            int column;

            do
            {
                Console.WriteLine();
                gameView.Turn(player.playerName, boardModel.columns);
            } while (!int.TryParse(Console.ReadLine(), out column) || column > boardModel.columns);

            return column;
        }

        public bool ColumnFull(BoardModel boardModel, int column)
        {
            if (boardModel.Get()[column - 1, 0] == "X" || boardModel.Get()[column - 1, 0] == "O")
            {
                gameView.ColumnFull();
                return true;
            }

            return false;
        }

        public bool BoardFull(BoardModel boardModel)
        {
            for (int column = 0; column < boardModel.columns; column++)
            {
                if (boardModel.Get()[column, 0] != "X" && boardModel.Get()[column, 0] != "O") return false;
            }

            return true;
        }

        public static void SetTurn(PlayersModel player, BoardModel boardModel, int column)
        {
            for (int row = boardModel.rows - 1; row >= 0; row--)
            {
                if (boardModel.Get()[column - 1, row] != "X" && boardModel.Get()[column - 1, row] != "O")
                {
                    boardModel.Edit(player.playerChar, column, row);
                    return;
                }
            }
            return;
        }

        public bool CheckFour(BoardModel boardModel, PlayersModel player)
        {
            for (int column = 0; column < boardModel.columns; column++)
            {
                for (int row = 0; row < boardModel.rows; row++)
                {
                    // Horizontal
                    if (column + 3 < boardModel.columns)
                    {
                        if (boardModel.Get()[column, row] == player.playerChar.ToString() &&
                            boardModel.Get()[column + 1, row] == player.playerChar.ToString() &&
                            boardModel.Get()[column + 2, row] == player.playerChar.ToString() &&
                            boardModel.Get()[column + 3, row] == player.playerChar.ToString())
                        { return true; }
                    }

                    // Vertical
                    if (row + 3 < boardModel.rows)
                    {
                        if (boardModel.Get()[column, row] == player.playerChar.ToString() &&
                        boardModel.Get()[column, row + 1] == player.playerChar.ToString() &&
                        boardModel.Get()[column, row + 2] == player.playerChar.ToString() &&
                        boardModel.Get()[column, row + 3] == player.playerChar.ToString())
                        { return true; }
                    }

                    // Diagonal up
                    if (column - 3 >= 0 && row + 3 < boardModel.rows)
                    {
                        if (boardModel.Get()[column, row] == player.playerChar.ToString() &&
                        boardModel.Get()[column - 1, row + 1] == player.playerChar.ToString() &&
                        boardModel.Get()[column - 2, row + 2] == player.playerChar.ToString() &&
                        boardModel.Get()[column - 3, row + 3] == player.playerChar.ToString())
                        { return true; }
                    }

                    // Diagonal down
                    if (column + 3 < boardModel.columns && row + 3 < boardModel.rows)
                    {
                        if (boardModel.Get()[column, row] == player.playerChar.ToString() &&
                        boardModel.Get()[column + 1, row + 1] == player.playerChar.ToString() &&
                        boardModel.Get()[column + 2, row + 2] == player.playerChar.ToString() &&
                        boardModel.Get()[column + 3, row + 3] == player.playerChar.ToString())
                        { return true; }
                    }
                }
            }

            return false;
        }

        public void end()
        {

        }
    }
}
