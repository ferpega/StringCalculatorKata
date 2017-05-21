using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorKata.Library.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void Add_WithNoNumbers_ReturnsRightResult()
        {
            var sut = new StringCalculator();
            var result = sut.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_WithOneNumber_ReturnsRightResult()
        {
            var sut = new StringCalculator();
            var result = sut.Add("1");
            Assert.AreEqual(1, result);
        }
    }
}
