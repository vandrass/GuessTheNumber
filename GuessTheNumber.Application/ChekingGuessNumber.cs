using System;

namespace GuessTheNumber.Application
{
    /// <summary>
    /// Class for cheking of user number with computer guess nummber.
    /// </summary>
    public class ChekingGuessNumber : ICheckingGuessNumber
    {
        /// <summary>
        /// Version for tests - Check input number with computer guess number and display messages by conditions.
        /// </summary>
        /// <param name="numberForGuessing">Number for guessing.</param>
        /// <param name="userInput">Input value.</param>
        public void CheckTheGuessNumber(NumberForGuessing numberForGuessing, string userInput)
        {
            int userNumber;
            string temp = userInput;
            AllToFalse(numberForGuessing);

            if (int.TryParse(temp, out userNumber))
            {
                if (userNumber == numberForGuessing.Number)
                {
                    numberForGuessing.IsEqual = true;
                }
                else if (userNumber <= numberForGuessing.Number)
                {
                   numberForGuessing.IsLow = true;
                }
                else
                {
                    numberForGuessing.IsHight = true;
                }
            }
            else
            {
                numberForGuessing.IsNotNumber = true;
            }
        }

        private void AllToFalse(NumberForGuessing numberForGuessing)
        {
            numberForGuessing.IsEqual = numberForGuessing.IsLow =
                numberForGuessing.IsHight = numberForGuessing.IsNotNumber = false;
        }
    }
}
