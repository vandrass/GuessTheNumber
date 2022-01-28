using GuessTheNumber.Application;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuessTheNumber.UnitTests
{
    [TestClass]
    public class CheckingGuessNumberTests
    {
        private readonly ServiceCollection _serviceCollection = new ServiceCollection();
        private ServiceProvider _provider;
        private ICheckingGuessNumber _service;

        [TestInitialize]
        public void TestInitialize()
        {
            _serviceCollection.AddScoped<ICheckingGuessNumber, ChekingGuessNumber>();
            _provider = _serviceCollection.BuildServiceProvider();
            _service = _provider.GetRequiredService<ICheckingGuessNumber>();
        }

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
