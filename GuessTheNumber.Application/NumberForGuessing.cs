using System;

namespace GuessTheNumber.Application
{
    /// <summary>
    /// Number that user need to guess.
    /// </summary>
    public class NumberForGuessing
    {
        // private GuessingNumberStatus numberStatus = GuessingNumberStatus.None;

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberForGuessing"/> class.
        /// </summary>
        public NumberForGuessing()
        {
            SetRandomNumber();
        }

        /// <summary>
        /// Gets or Sets guessing number sstatus.
        /// </summary>
        public GuessingNumberStatus NumberStatus { get; set; }

        /// <summary>
        /// Gets number for guessing.
        /// </summary>
        public int Number { get; private set; }

        private void SetRandomNumber()
        {
            var random = new Random();
            Number = random.Next(0, 100);
        }
    }
}