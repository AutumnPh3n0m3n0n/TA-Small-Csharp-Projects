using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDemo
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck toDeck { get; set; }
        public int Blance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(toDeck.Cards.First());
            Console.WriteLine(toDeck.Cards.First().ToString() + "\n");
            toDeck.Cards.RemoveAt(0);
        }
    }
}
