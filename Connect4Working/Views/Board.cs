using Connect4.Models;

namespace Connect4.Views
{
    internal class BoardView
    {

        public void getRows()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Hoeveel rijen moet het spelbord bevatten: ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void getColumns()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Hoeveel kolommen moet het spelbord bevatten: ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void draw(BoardModel boardModel)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int j = 0; j < boardModel.board.GetLength(0) + 2; j++)
            {
                Console.Write("■ ");
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Black;

            for (int i = 0; i < boardModel.board.GetLength(1); i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("■ ");
                Console.ForegroundColor = ConsoleColor.White;

                for (int j = 0; j < boardModel.board.GetLength(0); j++)
                {
                    Console.Write(boardModel.board[j, i] + " ");
                }

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("■\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int j = 0; j < boardModel.board.GetLength(0) + 2; j++)
            {
                Console.Write("■ ");
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
