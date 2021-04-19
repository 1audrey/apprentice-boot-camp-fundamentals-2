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
            

            for (int i = 0; i < rolls.Length; i += 2)
            {
                var firstRoll = rolls[i];
                var secondRoll = rolls[i + 1];

                if ((firstRoll + secondRoll) == 10)
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
