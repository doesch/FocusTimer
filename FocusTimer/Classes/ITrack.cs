using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Browsable(false)]
        public string FullPath  { get; }

        [DisplayName("Name")]
        public string DisplayName { get; }
    }
}
