using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    /// <summary>
    /// All Statistics
    /// </summary>
    internal class Statistics : IStatistics
    {
        private HashSet<StatisticsPerDay> m_AllDays;

        /// <summary>
        /// Statistics of the past days
        /// </summary>
        public HashSet<StatisticsPerDay> AllDays 
        {
            get 
            {
                if (m_AllDays == null)
                {
                    m_AllDays = new HashSet<StatisticsPerDay>();
                }

                return m_AllDays;
            }
            set 
            {
                m_AllDays = value;
            }
        }

        /// <summary>
        /// Returns the current day
        /// </summary>
        [JsonIgnore]
        public IStatisticsPerDay CurrentDay 
        {
            get 
            {
                var returnValue = AllDays.FirstOrDefault(x => x.DateTimeUtc.Date == DateTime.UtcNow.Date);

                // if not in list, create a new one
                if (returnValue == null)
                {
                    returnValue = new StatisticsPerDay();
                    AllDays.Add(returnValue);
                }                  

                return returnValue;
            }
        }

        public Statistics()
        {
            
        }
    }
}
