using GuessTheNumber.Application;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuessTheNumber.UnitTests
{
    /// <summary>
    /// Class for CheckingGuessNumber testing.
    /// </summary>
    [TestClass]
    public class CheckingGuessNumberTests
    {
        private readonly ServiceCollection _serviceCollection = new ServiceCollection();
        private ServiceProvider _provider;
        private ICheckingGuessNumber _service;

        /// <summary>
        /// Service collection for working with CheckingGuessNumber class.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _serviceCollection.AddScoped<ICheckingGuessNumber, ChekingGuessNumber>();
            _provider = _serviceCollection.BuildServiceProvider();
            _service = _provider.GetRequiredService<ICheckingGuessNumber>();
        }

        /// <summary>
        /// If computer number and user input number are equal.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberEqualToRandomNumber_IsEqualTrue()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = numberForGuessing.Number.ToString();
            var expected = GuessingNumberStatus.Equal;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.NumberStatus;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number lower than computer number.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberLowToRandomNumber_IsLowTrue()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number - 1).ToString();
            var expected = GuessingNumberStatus.Low;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.NumberStatus;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number higher than computer number.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberHigherToRandomNumber_IsHightTrue()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number + 1).ToString();
            var expected = GuessingNumberStatus.High;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.NumberStatus;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        /// <summary>
        /// If user input wasn`t number, IsNotNumber will be true.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NonNumericValue_IsNotNumberTrue()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = "12dsd";
            var expected = GuessingNumberStatus.None;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.NumberStatus;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
