using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name {get; set;}

        public List<Card> Hand = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public Card Draw(Deck deck, Player player)
        {
            string currentPlayer = player.Name;
            Card newCard = deck.Deal();
            System.Console.WriteLine($"{currentPlayer} drew {newCard.StringVal} of {newCard.Suit}");
            System.Console.WriteLine("-----------");
            Hand.Add(newCard);
            return newCard;
        }

        public Card Discard(int card)
        {
            if (Hand[card] != null)
            {
                Card toDiscard = Hand[card];
                Hand.Remove(toDiscard);
                return toDiscard;
            }
            return null;
            
        }
    }
}