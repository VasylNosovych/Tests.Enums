using System;

namespace Enums.Month
{
    /// <summary>
    /// <see cref="EMonth"/> management class
    /// </summary>
    public class MonthProvider
    {
        /// <summary>
        /// United set of operations to display <see cref="EMonth"/> functionality
        /// </summary>
        public void DisplayMonthWork()
        {
            int n;
            EMonth month;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\t Month");
                        Console.WriteLine();
                        Console.WriteLine("Please, read the number to display the respective month:");
                        Console.Write("n = ");
                        n = read_n();
                        Console.WriteLine();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                try
                {
                    month = FindMonth(n);
                    Console.WriteLine($"Chosen month: {month.ToString()}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        /// <summary>
        /// Method to read n (the number of month)
        /// </summary>
        /// <returns>Integer value to check the month</returns>
        private int read_n()
        {
            string nStr = Console.ReadLine();
            return Parse_n(nStr);
        }

        /// <summary>
        /// Parser from <see cref="string"/> to <see cref="int"/>
        /// </summary>
        /// <param name="nStr">String value</param>
        /// <returns>Parsed integer value</returns>
        public int Parse_n(string nStr)
        {
            int n;
            if (!int.TryParse(nStr, out n))
                throw new FormatException($"Can't parse '{nStr}' to the value of integer type.");
            return n;
        }

        /// <summary>
        /// Get the month by number
        /// </summary>
        /// <param name="n">Month number</param>
        /// <returns>Enum month value</returns>
        public EMonth FindMonth(int n)
        {
            if (n < 1 || n > 12)
                throw new MonthException(MonthException.MONTH_OUT_OF_RANGE);
            return (EMonth)n;
        }
    }
}
