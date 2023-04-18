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

            boardModel.columns = columns;
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

            boardModel.rows = rows;
            return rows;
        }

        public void createBoard(BoardModel boardModel, int columns, int rows)
        {
            string[,] board = new string[columns, rows];

            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < rows; row++)
                {
                    board[column, row] = "■";
                }
            }

            boardModel.board = board;

            return;
        }
    }
}
