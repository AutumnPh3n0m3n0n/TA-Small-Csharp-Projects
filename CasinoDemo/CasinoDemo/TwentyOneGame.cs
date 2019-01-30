using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDemo
{
    public class TwentyOneGame: Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player inPlayer in Players)
            {
                inPlayer.Hand = new List<Card>();
                inPlayer.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.toDeck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach (Player inPlayer in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successBet = inPlayer.Bet(bet);
                if (!successBet)
                {
                    //break this function
                    return;
                }
                Bets[inPlayer] = bet;
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");

                foreach (Player inPlayer in Players)
                {
                    Console.Write("{0}: ", inPlayer.Name);
                    Dealer.Deal(inPlayer.Hand);
                    if (i == 1)
                    {

                    }
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player inPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
