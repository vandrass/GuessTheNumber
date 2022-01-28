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
        /// If computer number and user input number are equal, method return string "equal".
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberEqualToRandomNumber_ReturnEqualString()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = numberForGuessing.Number.ToString();
            var expected = "equal";

            // Act
            var actual = _service.ToTestsCheckTheGuessNumber(numberForGuessing, inputNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If computer number and user input number are equal, propertie IsRightNumber must be 'true'.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberEqualToRandomNumber_TrueInNumberForGuessing()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = numberForGuessing.Number.ToString();
            bool expected = true;

            // Act
            _service.ToTestsCheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsRightNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number lower than computer number, method return string "low".
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberLowToRandomNumber_ReturnLowString()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number - 1).ToString();
            var expected = "low";

            // Act
            var actual = _service.ToTestsCheckTheGuessNumber(numberForGuessing, inputNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number lower than computer number, propertie IsRightNumber must be 'false'.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberLowToRandomNumber_FalseInNumberForGuessing()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number - 1).ToString();
            bool expected = false;

            // Act
            _service.ToTestsCheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsRightNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number higher than computer number, method return string "hight".
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberHigherToRandomNumber_ReturnHightString()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number + 1).ToString();
            var expected = "hight";

            // Act
            var actual = _service.ToTestsCheckTheGuessNumber(numberForGuessing, inputNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number higher than computer number, propertie IsRightNumber must be 'false'.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberHigherToRandomNumber_FalseInNumberForGuessing()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number + 1).ToString();
            bool expected = false;

            // Act
            _service.ToTestsCheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsRightNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user input wasn`t number, method return string "not numbers".
        /// </summary>
        [TestMethod]
        public void RandomNumber_NonNumericValue_ReturnNotNumbersString()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = "12dsd";
            var expected = "not numbers";

            // Act
            var actual = _service.ToTestsCheckTheGuessNumber(numberForGuessing, inputNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user input wasn`t number, propertie IsRightNumber must be 'false'.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NonNumericValue_FalseInNumberForGuessing()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = "12dsd";
            bool expected = false;

            // Act
            _service.ToTestsCheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsRightNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
