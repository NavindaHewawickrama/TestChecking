using TestLibrary;
using Xunit;

namespace TestProjectXUnit
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }
    }
}
