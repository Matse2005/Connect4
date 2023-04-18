using System.Data;

namespace Connect4.Models
{
    internal class BoardModel
    {
        public string[,] board;
        public int columns;
        public int rows;

        public string[,] Get()
        {
            return board;
        }

        public void Edit(Char playerChar, int column, int row)
        {
            board[column - 1, row] = playerChar.ToString();
            return;
        }
    }
}