using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Cards
{
    class Card : ICard
    {
        public Colors Color { get; set; }
        public int Number { get; set; }

        public Card(int color, int number)
        {
            Color = (Colors)color;
            Number = number;
        }
    }
}
