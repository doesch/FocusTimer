using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    /// <summary>
    /// The logservice
    /// </summary>
    public interface ILoggerService
    {
        /// <summary>
        /// write the logmessage to a file
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        public void Log(string pMessage);
    }
}
