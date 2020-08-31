using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards
{
    public interface ICard
    {
        public Colors Color { get; set; }
        public int Number { get; set; }
    }
}
