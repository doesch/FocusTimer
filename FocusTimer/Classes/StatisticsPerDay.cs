using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    public class StatisticsPerDay : IStatisticsPerDay
    {
        [Browsable(false)]
        public DateTime DateTimeUtc { get; set; } = DateTime.UtcNow.Date;

        [Browsable(false)]
        public TimeSpan FocusTime { get; set; }

        [Browsable(false)]
        public TimeSpan BreakTime { get; set; }

        [DisplayName("Date")]
        public string DateTimeDisplayValue { get { return DateTimeUtc.ToLocalTime().ToString(Constants.cDisplayFocusTimeDateFormat); } }

        [DisplayName("Focus Time")]
        public string FocusTimeDisplayValue { get { return FocusTime.ToString(Constants.cDisplayTimeFormatShort); } }
    }
}
