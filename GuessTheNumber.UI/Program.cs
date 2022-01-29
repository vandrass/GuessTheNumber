using System;
using GuessTheNumber.Application;
using Microsoft.Extensions.DependencyInjection;

namespace GuessTheNumber.UI
{
    /// <summary>
    /// Start program. UI interface.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// UI. The program create a number and the user has to guess it.
        /// if the user guessed the number, the program suggests continuing or exiting.
        /// </summary>
        public static void Main()
        {
            bool endOfWhile;
            var numberForGuessing = new NumberForGuessing();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ICheckingGuessNumber, ChekingGuessNumber>();
            var provider = serviceCollection.BuildServiceProvider();
            var service = provider.GetRequiredService<ICheckingGuessNumber>();

            do
            {
                Console.WriteLine("What number from 0 to 100 did the computer guess?");
                var userInput = Console.ReadLine();

                service.CheckTheGuessNumber(numberForGuessing, userInput);

                if (numberForGuessing.IsEqual)
                {
                    Console.WriteLine("Congratulation! You guessed the number!");
                    do
                    {
                        char answer;
                        endOfWhile = false;
                        Console.WriteLine("Do you want to continue? y/n");
                        answer = Console.ReadLine()[0];

                        if (answer == 'y')
                        {
                            numberForGuessing = new NumberForGuessing();
                            endOfWhile = true;
                        }
                        else if (answer == 'n')
                        {
                            numberForGuessing = null;
                            endOfWhile = true;
                        }
                    }
                    while (!endOfWhile);
                }
                else
                {
                    OutputMessages(numberForGuessing);
                }
            }
            while (numberForGuessing != null);
        }

        private static void OutputMessages(NumberForGuessing numberForGuessing)
        {
            if (numberForGuessing.IsLow)
            {
                Console.WriteLine("Your number is lower than Computer did guess");
            }
            else if (numberForGuessing.IsHight)
            {
                Console.WriteLine("Your number is higher than Computer did guess");
            }
            else
            {
                Console.WriteLine("Intager Numbers only!");
            }
        }
    }
}
