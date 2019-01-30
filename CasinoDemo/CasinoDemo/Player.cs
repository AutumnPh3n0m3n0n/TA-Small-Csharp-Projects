using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDemo
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public Player(string name, int beginBalance)
        {
            Hand = new List<Card>();
            Balance = beginBalance;
            Name = name;
        }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough money to bet that size!");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator +(Game inGame, Player inPlayer)
        {
            inGame.Players.Add(inPlayer);
                return inGame;
        }

        public static Game operator -(Game inGame, Player inPlayer)
        {
            inGame.Players.Remove(inPlayer);
            return inGame;
        }
    }
}
