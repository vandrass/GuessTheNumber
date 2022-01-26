using System;

namespace GuessTheNumber.Application
{
    /// <summary>
    /// Number that user need to guess.
    /// </summary>
    public class NumberForGuessing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberForGuessing"/> class.
        /// </summary>
        public NumberForGuessing()
        {
            SetRandomNumber();
        }

        /// <summary>
        /// Gets number for guessing.
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether true - if number guessed.
        /// </summary>
        public bool IsRightNumber { get; set; }

        private void SetRandomNumber()
        {
            var random = new Random();
            Number = random.Next(0, 100);
        }
    }
}