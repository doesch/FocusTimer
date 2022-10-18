using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    public class Track : ITrack
    {
        /// <summary>
        /// The fullpath to the file
        /// </summary>
        public string FullPath { get; private set; }

        /// <summary>
        /// The displayed name
        /// </summary>
        public string DisplayName 
        {
            get 
            {
                return Path.GetFileNameWithoutExtension(FullPath);
            } 
        }

        public Track(string pFullPath)
        {
            FullPath = pFullPath;
        }
    }
}
