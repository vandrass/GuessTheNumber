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
        /// If computer number and user input number are equal, IsEqual will be true.
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
        /// If computer number and user input number are equal, IsHight will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberEqualToRandomNumber_IsHightFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = numberForGuessing.Number.ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsHight;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If computer number and user input number are equal, IsLow will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberEqualToRandomNumber_IsLowFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = numberForGuessing.Number.ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsLow;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If computer number and user input number are equal, IsNotNumber will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberEqualToRandomNumber_IsNotNumberFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = numberForGuessing.Number.ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsNotNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number lower than computer number, IsLow will be true.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberLowToRandomNumber_IsLowTrue()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number - 1).ToString();
            var expected = true;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsLow;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number lower than computer number, IsEqual will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberLowToRandomNumber_IsEqualFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number - 1).ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsEqual;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number lower than computer number, IsHight will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberLowToRandomNumber_IsHightFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number - 1).ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsHight;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number lower than computer number, IsNotNumber will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberLowToRandomNumber_IsNotNumberFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number - 1).ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsNotNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number higher than computer number, IsHight will be true.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberHigherToRandomNumber_IsHightTrue()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number + 1).ToString();
            var expected = true;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsHight;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number higher than computer number, IsEqual will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberHigherToRandomNumber_IsEqualFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number + 1).ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsEqual;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number higher than computer number, IsLow will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberHigherToRandomNumber_IsLowFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number + 1).ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsLow;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user number higher than computer number, IsNotNumber will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NumberHigherToRandomNumber_IsNotNumberFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = (numberForGuessing.Number + 1).ToString();
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsNotNumber;

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
            var expected = true;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsNotNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user input wasn`t number, IsEqual will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NonNumericValue_IsEqualFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = "12dsd";
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsEqual;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user input wasn`t number, IsHight will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NonNumericValue_IsHightFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = "12dsd";
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsHight;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// If user input wasn`t number, IsLow will be false.
        /// </summary>
        [TestMethod]
        public void RandomNumber_NonNumericValue_IsLowFalse()
        {
            // Arrange
            var numberForGuessing = new NumberForGuessing();
            var inputNumber = "12dsd";
            bool expected = false;

            // Act
            _service.CheckTheGuessNumber(numberForGuessing, inputNumber);
            var actual = numberForGuessing.IsLow;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
