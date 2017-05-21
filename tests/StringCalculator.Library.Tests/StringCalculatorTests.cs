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
    }
}
