using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    /// <summary>
    /// global constants here
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// The displayed timeformat 
        /// </summary>
        public const string cDisplayTimeFormat = "hh\\:mm\\:ss";

        /// <summary>
        /// Format of the focus time in the statistics table
        /// </summary>
        public const string cDisplayFocusTimeDateFormat = "ddd, dd MMM";

        /// <summary>
        /// The displayed timeformat without seconds
        /// </summary>
        public const string cDisplayTimeFormatShort = "hh\\:mm";

        /// <summary>
        /// The logtime format
        /// </summary>
        public const string cLogTimeFormat = "yyyy-MM-dd hh:mm";

        /// <summary>
        /// The path to the 
        /// </summary>

#if RELEASE
        private const string cDatabaseFileName = "database.json";
        private const string cLogFileName = "log.txt";
#else
        private const string cDatabaseFileName = "database.debug.json";
        private const string cLogFileName = "log.debug.txt";
#endif

        public static readonly string FullPathToJsonFile = Path.Combine(Application.LocalUserAppDataPath, cDatabaseFileName);
        public static readonly string FullPathToLogfile = Path.Combine(Application.LocalUserAppDataPath, cLogFileName);
    }
}
