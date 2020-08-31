using HouseOfCards.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Factories
{
    public class CardsFactory
    {
        public Stack<ICard> GetCardStack()
        {
            Stack<ICard> cardStack = new Stack<ICard>();
            for (int i = 0; i < 5; i++)
            {
                //creating 3 cards number 1
                for (int j = 0; j < 3; j++)
                {
                    cardStack.Push(new Card(i, 1));
                }
                //creating 2,3,4 cards

                for (int j = 0; j < 3; j++)
                {
                    for (int l = 0; l < 2; l++)
                    {
                        cardStack.Push(new Card(i, j + 2));
                    }
                }
                cardStack.Push(new Card(i, 5));
            }
            cardStack = ShuffleCards(cardStack);
            return cardStack;

        }
        private Stack<ICard> ShuffleCards(Stack<ICard> cardsToShuffle)
        {
            Random rnd = new Random();
            return new Stack<ICard>(cardsToShuffle.OrderBy(x => rnd.Next()));
        }
        
    }
}
