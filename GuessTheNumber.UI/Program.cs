using System;
using GuessTheNumber.Application;
using Microsoft.Extensions.DependencyInjection;

namespace GuessTheNumber.UI
{
    public class Program
    {
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
                service.CheckTheGuessNumber(numberForGuessing);

                if (numberForGuessing.IsRightNumber)
                {
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
            }
            while (numberForGuessing != null);
        }
    }
}
