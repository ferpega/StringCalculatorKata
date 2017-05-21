using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculatorKata.Library.Tests
{
    [TestClass]
    public class InputStringManagerTests
    {
        [TestMethod]
        public void Parse_WithEmptyString_ReturnsRightResults()
        {
            var sut = new InputStringManager("");
            Assert.AreEqual(",", sut.Delimiter);
            CollectionAssert.AreEqual(new string[] { "" }, sut.NumberStrings);
        }

        [TestMethod]
        public void Parse_WithOneNumber0String_ReturnsRightResults()
        {
            var sut = new InputStringManager("0");
            Assert.AreEqual(",", sut.Delimiter);
            CollectionAssert.AreEqual(new string[] { "0" }, sut.NumberStrings);
        }

        [TestMethod]
        public void Parse_WithOneNumber1String_ReturnsRightResults()
        {
            var sut = new InputStringManager("1");
            Assert.AreEqual(",", sut.Delimiter);
            CollectionAssert.AreEqual(new string[] { "1" }, sut.NumberStrings);
        }

        [TestMethod]
        public void Parse_WithTwoNumbers1And2String_ReturnsRightResults()
        {
            var sut = new InputStringManager("1,2");
            Assert.AreEqual(",", sut.Delimiter);
            CollectionAssert.AreEqual(new string[] { "1", "2" }, sut.NumberStrings);
        }

        [TestMethod]
        public void Parse_WithDelimiterNewLineAndThreeNumbersString_ReturnsRightResults()
        {
            var sut = new InputStringManager("1\n2,3");
            Assert.AreEqual(",", sut.Delimiter);
            CollectionAssert.AreEqual(new string[] { "1", "2", "3" }, sut.NumberStrings);
        }

        [TestMethod]
        public void Parse_WithSpecifiedDelimiterAndThreeNumbersString_ReturnsRightResults()
        {
            var sut = new InputStringManager("//;\n1;2");
            Assert.AreEqual(";", sut.Delimiter);
            CollectionAssert.AreEqual(new string[] { "1", "2" }, sut.NumberStrings);
        }
    }
}
