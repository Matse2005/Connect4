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
                gameView.Turn(player.playerName, boardModel.Columns);
            } while (!int.TryParse(Console.ReadLine(), out column) || column > boardModel.Columns);

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
            for (int i = 0; i < boardModel.columns; i++)
            {
                if (boardModel.Get()[i, 0] != "X" && boardModel.Get()[i, 0] != "O") return false;
            }

            return true;
        }

        public static void SetTurn(PlayersModel player, BoardModel boardModel, int column)
        {
            for (int i = boardModel.rows - 1; i >= 0; i--)
            {
                if (boardModel.Get()[column - 1, i] != "X" && boardModel.Get()[column - 1, i] != "O")
                {
                    Console.WriteLine("nummer " + boardModel.Get()[column - 1, i]);
                    boardModel.Edit(player.playerChar, column, i);
                    return;
                }
            }
            return;
        }

        public bool CheckFour(BoardModel boardModel, PlayersModel player)
        {


            return false;
        }
    }
}
