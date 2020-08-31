using HouseOfCards.GameMenu.Validations;
using HouseOfCards.IO;
using MenuBuilder.menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseOfCards.Factories
{
    class BoardFactory
    {
        public void GetBoard()
        {
            Output.Print("Enter number of players to play (2 - 4)");
            string playersNumber = Console.ReadLine();
            IInputvalidation inputvalidation = new NumOfPlayersValidation();
            while (!inputvalidation.Validate(playersNumber))
            {
                Output.Print("Please enter valid number between 2 - 4");
                playersNumber = Console.ReadLine();
            }


        }
    }
}
