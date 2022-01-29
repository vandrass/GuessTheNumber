namespace GuessTheNumber.Application
{
    /// <summary>
    /// Interface for cheking of user number with computer guess nummber.
    /// </summary>
    public interface ICheckingGuessNumber
    {
        /// <summary>
        /// Version for tests - Check input number with computer guess number and display messages by conditions.
        /// </summary>
        /// <param name="numberForGuessing">Number for guessing.</param>
        /// <param name="userInput">Input value.</param>
        public void CheckTheGuessNumber(NumberForGuessing numberForGuessing, string userInput);
    }
}
