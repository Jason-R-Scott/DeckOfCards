using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck ();

            Player riker = new Player("Riker");

            deck.Shuffle();

            deck.ReadDeck();

            // deck.Deal();
            // deck.Deal();
            // deck.Deal();
            // deck.Deal();

            riker.Draw(deck, riker);
            riker.Draw(deck, riker);
            riker.Draw(deck, riker);
            riker.Draw(deck, riker);
            riker.Draw(deck, riker);

            System.Console.WriteLine(riker.Hand);
            // deck.Reset();

            deck.ReadDeck();
        }
    }
}
