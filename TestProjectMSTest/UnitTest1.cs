using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace TestProjectMSTest
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ReturnsCorrectSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_ReturnsCorrectDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }
    }
}
