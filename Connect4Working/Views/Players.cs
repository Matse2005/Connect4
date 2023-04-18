namespace Connect4.Views
{
    internal class PlayersView
    {
        public void getName(int number)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"Speler {number} wat is uw naam: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
