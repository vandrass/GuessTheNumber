using System;

namespace GuessTheNumber.Application
{
    public class ChekingGuessNumber : ICheckingGuessNumber
    {
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
                Console.WriteLine("Numbers only");
            }
        }
    }
}
