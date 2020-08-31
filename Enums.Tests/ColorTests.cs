using Enums.Color;
using NUnit.Framework;
using System.Collections.Generic;

namespace Enums.Tests
{
    public class Tests
    {
        [Test]
        public void ColorExtentions_SortColors_ReturnsCollectionInCorrectOrder()
        {
            IEnumerable<EColor> expected = new List<EColor>
            {
                EColor.Gray,
                EColor.Blue,
                EColor.Green,
                EColor.Black,
                EColor.Brown,
                EColor.Red,
                EColor.Yellow,
                EColor.White
            };
            EColor colorObject = EColor.Black;

            IEnumerable<EColor> actual = colorObject.SortColors();

            Assert.AreEqual(expected, actual);
        }
    }
}