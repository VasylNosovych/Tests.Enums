using Enums.Long;
using NUnit.Framework;

namespace Enums.Tests
{
    public class LongRangeTests
    {
        [Test]
        public void LongRange_Max_EqualsMaxLongValue()
        {
            long expected = long.MaxValue;
            long actual = (long)LongRange.Max;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongRange_Min_EqualsMinLongValue()
        {
            long expected = long.MinValue;
            long actual = (long)LongRange.Min;
            Assert.AreEqual(expected, actual);
        }
    }
}
