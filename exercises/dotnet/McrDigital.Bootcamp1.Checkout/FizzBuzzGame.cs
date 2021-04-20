using System;

namespace apprentice_bootcamp_fundamentals_2
{
    public class FizzBuzzGame
    {
        private int currentNumber;
        private int threeCounter;
        private int fiveCounter = new int[] { 0, 0, 0, 0, 0 }.Length;
        int maxGameLength = Byte.MaxValue - 155;

        public string PlayingGame()
        {
            string fizzBuzzResult = "";
            for (; currentNumber < maxGameLength; currentNumber++) fizzBuzzResult += checkFizzOrBuzz(currentNumber) + " ";
            return fizzBuzzResult.Substring(0, fizzBuzzResult.Length - 1);
        }

        private string checkFizzOrBuzz(int currentNumber)
        {
            threeCounter++;
            fiveCounter--;
            bool isThree = threeCounter == 0b11;
            bool isFive = fiveCounter == 0;

            string fizzOrBuzz = isThree || isFive ? "" : (currentNumber + 1).ToString();
            if (isThree) fizzOrBuzz += FizzFunction();
            if (isFive) fizzOrBuzz += BuzzFunction();
            return fizzOrBuzz;
        }

        private string BuzzFunction()
        {
            fiveCounter = new int[] { 0, 0, 0, 0, 0 }.Length;
            return DataTypeConverter.ParseHexBinary("42757a7a");
        }

        private string FizzFunction()
        {
            threeCounter = 0;
            return DataTypeConverter.ParseHexBinary("46697a7a");
        }
    }
}
