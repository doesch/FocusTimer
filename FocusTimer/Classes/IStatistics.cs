using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    /// <summary>
    /// manages all statistics
    /// </summary>
    public interface IStatistics
    {
        /// <summary>
        /// Unique list of statistics of all Days
        /// </summary>
        public HashSet<StatisticsPerDay> AllDays { get; set; }

        /// <summary>
        /// Statistics of the current day
        /// </summary>
        [JsonIgnore]
        public IStatisticsPerDay CurrentDay { get; }
    }
}
