using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    public class StatisticsPerDay : IStatisticsPerDay
    {
        public DateTime DateTimeUtc { get; set; } = DateTime.UtcNow.Date;
        public TimeSpan FocusTime { get; set; }
        public TimeSpan BreakTime { get; set; }
    }
}
