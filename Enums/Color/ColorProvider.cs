using System;

namespace Enums.Color
{
    /// <summary>
    /// <see cref="EColor"/> management class
    /// </summary>
    public class ColorProvider
    {
        /// <summary>
        /// United set of operations to display <see cref="EColor"/> functionality
        /// </summary>
        public void DisplaySortedByCode()
        {
            Console.WriteLine("\t Color");
            Console.WriteLine();
            EColor colorObject= EColor.Black;
            var sortedColors = colorObject.SortColors();
            foreach (var color in sortedColors)
            {
                Console.WriteLine($"{color}: {(int)color}");
            }
        }
    }
}
