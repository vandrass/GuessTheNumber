using System;
using GuessTheNumber.Application;

namespace GuessTheNumber.UI
{
    internal class Program
    {
        public static void Main()
        {
            var numberForGuessing = new NumberForGuessing();
            do
            {
                Console.WriteLine("What number from 0 to 100 did the computer guess?");
                InputValidation();
            }
            while (numberForGuessing.IsRightNumber);
        }

        private static void InputValidation()
        {
            var temp = Console.ReadLine();
            int number;

            if (int.TryParse(temp, out number))
            {

            }
        }
    }
}
