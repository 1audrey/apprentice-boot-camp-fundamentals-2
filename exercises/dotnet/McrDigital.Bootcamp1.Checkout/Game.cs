using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Game
    {

        public int Score(int [] rolls)
        {
            var score = 0;
            int increment = 2;

            bool IsSpare(int firstRoll, int secondRoll)
            {
                return (firstRoll + secondRoll) == 10 && (firstRoll != 10);
            }
            
            bool IsStrike(int firstRoll)
            {
                return (firstRoll == 10);
            }

            for (int i = 0; i < rolls.Length; i += increment)
            {
                increment = 2;
                var firstRoll = rolls[i];
                var secondRoll = rolls[i + 1];
                var spare = IsSpare(firstRoll, secondRoll);
                var strike = IsStrike(firstRoll);

                if (strike)
                {
                    increment = 1;
                    score += rolls[i + 2] + rolls[i + 3];
                }

                else if (spare)
                {
                    score += rolls[i + 2]; //this is the first roll from the next frame
                }
                

                score += firstRoll;
                score += secondRoll;

                
            }

            return score;
        }

    }
}
