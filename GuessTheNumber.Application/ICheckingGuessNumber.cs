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
    }
}
