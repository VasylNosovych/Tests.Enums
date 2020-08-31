using System;
using System.Runtime.Serialization;

namespace Enums.Month
{
    /// <summary>
    /// Custom exception for <see cref="EMonth"/>
    /// </summary>
    [Serializable]
    public class MonthException : Exception
    {
        /// <summary>
        /// Predefined error message in case when month number is not from 1 to 12
        /// </summary>
        public const string MONTH_OUT_OF_RANGE = "Month number is out of range: try value from 1 to 12.";

        /// <summary>
        /// Default constructor
        /// </summary>
        public MonthException() : base() { }

        /// <summary>
        /// Constructor with error message
        /// </summary>
        /// <param name="message">Error message</param>
        public MonthException(string message) : base(message) { }

        /// <summary>
        /// Constructor with error message and inner exception
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerEx">Inner exception</param>
        public MonthException(string message, Exception innerEx) : base(message, innerEx) { }

        /// <summary>
        /// Constructor with serialization data
        /// </summary>
        /// <param name="info">Serialization information</param>
        /// <param name="context">Streaming context data</param>
        public MonthException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
