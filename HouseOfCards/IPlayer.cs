using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards
{
    interface IPlayer
    {
        public ICard[] CardsInHand { get; set; }
        public IBoard PlayingBoard { get; set; }
        public IPlayer[] PlayersPlaying { get; set; }
        public int PlayerId { get; set; }
        public void PlutCard();
        public void GetHint();
        public void ThrowCard();
        public void StartTurn();

    }
}
