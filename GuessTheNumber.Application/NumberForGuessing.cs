using System;

namespace GuessTheNumber.Application
{
    public class NumberForGuessing
    {
        public NumberForGuessing()
        {
            SetRandomNumber();
        }

        public int Number { get; private set; }

        public bool IsRightNumber { get; set; }

        public void SetRandomNumber()
        {
            var random = new Random();
            Number = random.Next(0, 100);
        }
    }
}