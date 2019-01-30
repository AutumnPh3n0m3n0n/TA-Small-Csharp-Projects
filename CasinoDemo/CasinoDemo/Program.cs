using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welsome to the Hotel+Casino. Let's start by giving us your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y" || answer == "yeah" || answer == "ya" || answer == "yo")
            {
                Player player1 = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player1;
                player1.isActivelyPlaying = true;
                while (player1.isActivelyPlaying && player1.Balance > 0)
                {
                    game.Play();
                }
                game -= player1;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Good bye! We enjoyed your company and participation.");
            Console.ReadLine();
        }
    }
}
