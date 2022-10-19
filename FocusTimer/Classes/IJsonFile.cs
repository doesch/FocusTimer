using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    /// <summary>
    /// Handles the json file
    /// </summary>
    public interface IJsonFile
    {
        public IStatistics Statistics { get; set; }

        public void Export();

        public void Import();
    }
}
