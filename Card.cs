using System;
using System.Linq;

namespace DeckOfCards
{
    public class Card
    {
        public string StringVal {get;set;}
        public string Suit {get;set;}
        public int Val {get;set;}

        public Card(string faceVal, string suitVal, int val)
        {
            StringVal = faceVal;
            Suit = suitVal;
            Val = val;
        }
    }
}