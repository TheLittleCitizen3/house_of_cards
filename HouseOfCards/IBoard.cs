using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards
{
    interface IBoard
    {
        public Stack<ICard> CardStack { get; set; }
        public IPlayer[] Players { get; set; }
        public ICard[] TableBoard { get; set; }
        public int HintsLeft { get; set; }
        public UriHostNameType StrikesLeft { get; set; }
        public void PlaceCard(ICard card);
        public ICard GetHint(IPlayer player);
        public ICard ThrowCard();
        public void Startgame();
        public void PrintBoard();
        public void PrintPlayersCards(IPlayer CurrentPlayer);
    }
}
