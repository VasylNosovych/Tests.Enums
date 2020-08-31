using System;
using System.Collections.Generic;
using System.Linq;

namespace Enums.Color
{
    /// <summary>
    /// Extention to <see cref="EColor"/>
    /// </summary>
    public static class ColorExtentions
    {
        /// <summary>
        /// Sorts <see cref="EColor"/> records by color code
        /// </summary>
        /// <param name="colorEnum">The type of target object to be extented</param>
        /// <returns>Sorted collection of colors</returns>
        public static IEnumerable<EColor> SortColors(this Enum colorEnum)
        {
            var colors = Enum.GetValues(colorEnum.GetType()).Cast<EColor>();
            return colors;
        }
    }
}
