using HouseOfCards.Cards;
using HouseOfCards.Factories;
using System;
using System.Collections.Generic;

namespace HouseOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CardsFactory cardsFactory = new CardsFactory();
            Stack<ICard> cards = cardsFactory.GetCardStack();
            Console.WriteLine(cards.ToString());
            //TODO: create factory for each component int board factory
            //TODO: create menu containing action class for each action from interface IACTiON and validation class for input validation in menu - type IValidation
        }
    }
}
