using Connect4.Models;
using Connect4.Views;

namespace Connect4.Controllers
{
    internal class PlayersController
    {
        PlayersView playersView = new();

        public void setPlayer(PlayersModel player, char playerChar, int number)
        {
            Console.Clear();
            playersView.getName(number);
            string name = Console.ReadLine();

            if (name == null || name == "" || name == " ")
            {
                setPlayer(player, playerChar, number);
                return;
            }

            player.playerName = name;
            player.playerChar = playerChar;
            return;
        }
    }
}
