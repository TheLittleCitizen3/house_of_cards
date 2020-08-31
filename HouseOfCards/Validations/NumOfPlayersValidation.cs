using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.menu;
using Microsoft.Win32.SafeHandles;

namespace HouseOfCards.GameMenu.Validations
{
    class NumOfPlayersValidation : IInputvalidation
    {
        public bool Validate(string userInput)
        {
            int choice = int.Parse(userInput);
            return choice >= 2 && choice <= 4;
        }
    }
}
