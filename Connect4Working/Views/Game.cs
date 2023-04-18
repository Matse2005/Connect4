using System.Xml.Linq;

namespace Connect4.Views
{
    internal class GameView
    {
        public void Turn(string name, int max)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{name} geef een nummer van 1 tot {max}: ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ColumnFull()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Deze kolom is vol, kies een nieuwe kolom.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Win(string name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{name} is de winnaar");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void BoardFull()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Het bord is vol, het is een gelijkstand");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
