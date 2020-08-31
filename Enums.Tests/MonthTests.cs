using Enums.Month;
using NUnit.Framework;
using System;

namespace Enums.Tests
{
    public class MonthTests
    {
        private MonthProvider _provider;

        [SetUp]
        public void Setup()
        {
            _provider = new MonthProvider();
        }

        [Test]
        public void EMonth_January_WithCode1()
        {
            int expected = 1;
            int actual = (int)EMonth.January;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(1, EMonth.January)]
        [TestCase(4, EMonth.April)]
        [TestCase(12, EMonth.December)]
        public void MonthProviderFindMonth_GetFromValidRange_ReturnsMonth(int n, EMonth expected)
        {
            EMonth actual = _provider.FindMonth(n);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(0)]
        [TestCase(13)]
        [TestCase(-4)]        
        public void MonthProviderFindMonth_GetOutOfRange_ThrowsMonthException(int n)
        {
            Assert.Throws<MonthException>(
                () => _provider.FindMonth(n)
                , "MonthProvider.FindMinth(int) should throw MonthException while searching out of range [1;12]."
            );
        }

        [Test]
        [TestCase("1", 1)]
        [TestCase("13", 13)]
        [TestCase("-39", -39)]
        [TestCase("2147483647", int.MaxValue)]
        [TestCase("-2147483648", int.MinValue)]
        public void MonthProviderParse_n_GetValidData_SuccessfullyParsed(string nStr, int expected)
        {
            int actual = _provider.Parse_n(nStr);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase("1OO")]
        [TestCase("Monthcode")]
        [TestCase("12!")]
        [TestCase("")]
        [TestCase("  ")]
        public void MonthProviderParse_n_GetInvalidData_ThrowsFormatException(string nStr)
        {
            Assert.Throws<FormatException>(
                () => _provider.Parse_n(nStr)
                , "MonthProvider.Parse_n(string) should throw FormatException while parsing invalid string format."
            );
        }
    }
}
