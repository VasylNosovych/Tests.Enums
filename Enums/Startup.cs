using Enums.Color;
using Enums.Long;
using Enums.Month;
using System;

namespace Enums
{
    /// <summary>
    /// Class to organize program algorithm
    /// </summary>
    public static class Startup
    {
        /// <summary>
        /// Program algorithm
        /// </summary>
        public static void Start()
        {
            initialInfo();
            Console.Clear();
            
            new LongRangeProvider().Display();
            Console.ReadLine();
            Console.Clear();

            new ColorProvider().DisplaySortedByCode();
            Console.ReadLine();
            Console.Clear();

            new MonthProvider().DisplayMonthWork();
            Console.ReadLine();
            Console.Clear();
            
            bye();
        }

        /// <summary>
        /// Display short initial description
        /// </summary>
        static void initialInfo()
        {
            Console.WriteLine("You are going to see the realization of three parts of task one by one:");
            Console.WriteLine("   1. LongRange");
            Console.WriteLine("   2. Color");
            Console.WriteLine("   3. Month");
            Console.WriteLine();
            Console.WriteLine("Press Enter to start:");
            Console.ReadLine();
        }

        /// <summary>
        /// The end of the algorithm
        /// </summary>
        static void bye()
        {
            Console.WriteLine("Bye!");
        }
    }
}
