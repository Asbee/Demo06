using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3
{
    class Deck
    {
        private List<Suits> deck;

        public Deck()
        {
            deck = new List<Suits>();
        }
        public void AddCard(Suits cards)
        {
            deck.Add(cards);
        }

        
    }
}
