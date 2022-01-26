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
    }
}
