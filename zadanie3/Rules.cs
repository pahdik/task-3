using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie3
{
    class Rules
    {
        public int numberOfValue { get; set; }
        public Rules(int num)
        {
            numberOfValue = num;
        }
        public string result(int Player, int Computer)
        {
            if (Player == Computer) return "The same values";
            if (Math.Abs(Player-Computer)<= (numberOfValue-1)/2)
            {                
                return Player > Computer ? "Computer win!" : "You win!";
            }
            else
            {
                return Player > Computer ? "You win!" : "Computer win!";
            }
        } 
    }
}
