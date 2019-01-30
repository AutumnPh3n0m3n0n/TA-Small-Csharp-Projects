using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDemo
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player inPlayer in Players)
            {
                Console.WriteLine(inPlayer.Name);
            }
        }
    }
}
