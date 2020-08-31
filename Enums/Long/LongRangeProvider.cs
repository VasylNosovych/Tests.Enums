using System;

namespace Enums.Long
{
    /// <summary>
    /// <see cref="LongRange"/> management class
    /// </summary>
    public class LongRangeProvider
    {
        /// <summary>
        /// United set of operations to display <see cref="LongRange"/> functionality
        /// </summary>
        public void Display()
        {
            Console.WriteLine("\t LongRange");
            Console.WriteLine();
            Console.WriteLine($"Minimum long value: {(long)LongRange.Min}");
            Console.WriteLine($"Maximum long value:  {(long)LongRange.Max}");
        }
    }
}
