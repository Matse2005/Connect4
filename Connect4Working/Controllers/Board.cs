using Connect4.Models;
using Connect4.Views;

namespace Connect4.Controllers
{
    internal class BoardController
    {
        BoardView boardView = new();

        public void setBoard(BoardModel boardModel)
        {
            this.createBoard(boardModel, this.getColumns(boardModel), this.getRows(boardModel));

            return;
        }

        public int getColumns(BoardModel boardModel)
        {
            int columns;

            do
            {
                Console.Clear();
                boardView.getColumns();
            } while (!int.TryParse(Console.ReadLine(), out columns));

            boardModel.Columns = columns;
            return columns;
        }

        public int getRows(BoardModel boardModel)
        {
            int rows;

            do
            {
                Console.Clear();
                boardView.getRows();
            } while (!int.TryParse(Console.ReadLine(), out rows));

            boardModel.Rows = rows;
            return rows;
        }

        public void createBoard(BoardModel boardModel, int columns, int rows)
        {
            string[,] board = new string[columns, rows];

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    board[i, j] = "■";
                }
            }

            boardModel.board = board;

            return;
        }
    }
}
