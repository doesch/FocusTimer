using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    /// <summary>
    /// Stats per day
    /// </summary>
    public interface IStatisticsPerDay
    {
        /// <summary>
        /// Stats for the Date (Identifier)
        /// </summary>
        [DisplayName("Date")]
        public DateTime DateTimeUtc { get; set; }

        /// <summary>
        /// The total focus time for this day
        /// </summary>
        [DisplayName("Focus Time")]
        public TimeSpan FocusTime { get; set; }

        /// <summary>
        /// Your break time
        /// </summary>
        [Browsable(false)]
        public TimeSpan BreakTime { get; set; }
    }
}
