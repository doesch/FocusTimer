using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    /// <summary>
    /// A Track
    /// </summary>
    public interface ITrack
    {
        public string DisplayTitle { get; set; }

        public string FullPath  { get; set; }
    }
}
