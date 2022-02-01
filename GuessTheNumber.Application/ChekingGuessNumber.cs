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
            numberForGuessing.NumberStatus = GuessingNumberStatus.None;

            if (int.TryParse(temp, out userNumber))
            {
                if (userNumber == numberForGuessing.Number)
                {
                    numberForGuessing.NumberStatus = GuessingNumberStatus.Equal;
                }
                else if (userNumber <= numberForGuessing.Number)
                {
                    numberForGuessing.NumberStatus = GuessingNumberStatus.Low;
                }
                else
                {
                    numberForGuessing.NumberStatus = GuessingNumberStatus.High;
                }
            }
        }
    }
}
