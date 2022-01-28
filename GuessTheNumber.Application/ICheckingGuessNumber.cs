namespace GuessTheNumber.Application
{
    /// <summary>
    /// Interface for cheking of user number with computer guess nummber.
    /// </summary>
    public interface ICheckingGuessNumber
    {
        /// <summary>
        /// Check input number with computer guess number and display messages by conditions.
        /// </summary>
        /// <param name="number">Number for checking.</param>
        public void CheckTheGuessNumber(NumberForGuessing number);

        /// <summary>
        /// Version for tests - Check input number with computer guess number and display messages by conditions.
        /// </summary>
        /// <param name="numberForGuessing">Number for guessing.</param>
        /// <param name="userInput">Input value.</param>
        /// <returns>string with message for tests.</returns>
        public string ToTestsCheckTheGuessNumber(NumberForGuessing numberForGuessing, string userInput);
    }
}
