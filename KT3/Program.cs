using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Deck deck = new Deck();
            Suits suits = new Suits();

            while(true)
            {
                if (suits.Diamonds <= 13)
                {

                    deck.AddCard(x);
                    suits.Diamonds++;
                }
                break;
            }
            Console.WriteLine(" = {0}", suits.Diamonds);
        }
    }
}
