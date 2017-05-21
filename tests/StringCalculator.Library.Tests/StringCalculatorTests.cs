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
        public void Add_WithNumber1_ReturnsRightResult()
        {
            var sut = new StringCalculator();
            var result = sut.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Add_WithTwoNumbers1And2_ReturnsRightResult()
        {
            var sut = new StringCalculator();
            var result = sut.Add("1,2");
            Assert.AreEqual(3, result);
        }
    }
}
