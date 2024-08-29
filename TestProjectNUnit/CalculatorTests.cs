using NUnit.Framework;
using TestLibrary;

namespace TestProjectNUnit
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ReturnsCorrectSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_ReturnsCorrectDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }
    }
}
