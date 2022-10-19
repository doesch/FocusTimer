using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
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
        /// The path to the 
        /// </summary>
        public static readonly string FullPathToJsonFile = Path.Combine(Application.LocalUserAppDataPath, "database.json");
    }
}
