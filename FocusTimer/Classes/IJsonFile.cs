using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    /// <summary>
    /// Handles the json file
    /// </summary>
    public interface IJsonFileService
    {
        public IStatistics Statistics { get; set; }

        public void Export();

        public void Import();
    }
}
