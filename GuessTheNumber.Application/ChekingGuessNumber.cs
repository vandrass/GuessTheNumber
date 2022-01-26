using System;

namespace GuessTheNumber.Application
{
    /// <summary>
    /// Class for cheking of user number with computer guess nummber.
    /// </summary>
    public class ChekingGuessNumber : ICheckingGuessNumber
    {
        /// <summary>
        /// Check input number with computer guess number and display messages by conditions.
        /// </summary>
        /// <param name="numberForGuessing">Number for guessing.</param>
        public void CheckTheGuessNumber(NumberForGuessing numberForGuessing)
        {
            int userNumber;
            string temp = Console.ReadLine();

            if (int.TryParse(temp, out userNumber))
            {
                if (userNumber == numberForGuessing.Number)
                {
                    Console.WriteLine("Congratulation! You guessed the number!");
                    numberForGuessing.IsRightNumber = true;
                }
                else if (userNumber <= numberForGuessing.Number)
                {
                    Console.WriteLine("Your number is lower than Computer did guess");
                }
                else
                {
                    Console.WriteLine("Your number is higher than Computer did guess");
                }
            }
            else
            {
                Console.WriteLine("Numbers only!");
            }
        }

        /// <summary>
        /// Version for tests - Check input number with computer guess number and display messages by conditions.
        /// </summary>
        /// <param name="numberForGuessing">Number for guessing.</param>
        /// <param name="userInput">Input value.</param>
        public void ToTestsCheckTheGuessNumber(NumberForGuessing numberForGuessing, string userInput)
        {
            int userNumber;
            string temp = userInput;

            if (int.TryParse(temp, out userNumber))
            {
                if (userNumber == numberForGuessing.Number)
                {
                    Console.WriteLine("Congratulation! You guessed the number!");
                    numberForGuessing.IsRightNumber = true;
                }
                else if (userNumber <= numberForGuessing.Number)
                {
                    Console.WriteLine("Your number is lower than Computer did guess");
                }
                else
                {
                    Console.WriteLine("Your number is higher than Computer did guess");
                }
            }
            else
            {
                Console.WriteLine("Numbers only!");
            }
        }
    }
}
