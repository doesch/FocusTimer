using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    /// <summary>
    /// Stats per day
    /// </summary>
    public interface IStatisticsPerDay
    {
        /// <summary>
        /// Stats for the Date (Identifier)
        /// </summary>
        public DateTime DateTimeUtc { get; set; }

        /// <summary>
        /// The total focus time for this day
        /// </summary>
        public TimeSpan FocusTime { get; set; }
        
        /// <summary>
        /// Your break time
        /// </summary>
        public TimeSpan BreakTime { get; set; }
    }
}
