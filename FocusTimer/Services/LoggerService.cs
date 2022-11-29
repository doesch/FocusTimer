using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    /// <summary>
    /// Logger service
    /// </summary>
    public class LoggerService : ILoggerService
    {
        private string m_PathToLogfile;

        public LoggerService(string pPathToLogfile)
        {
            m_PathToLogfile = pPathToLogfile;
            Init();
        }

        /// <summary>
        /// Logfile
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Init()
        {
            // create directory if not exists
            if (!Directory.Exists(Path.GetDirectoryName(m_PathToLogfile)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(m_PathToLogfile));
            }

            // create logfile if not exists
            if (!File.Exists(m_PathToLogfile))
            {
                // create logfile
                File.Create(m_PathToLogfile);
            }
        }

        /// <summary>
        /// log file
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public void Log(string pMessage)
        {
            // create message
            var message = $"{DateTime.Now.ToString(Constants.cLogTimeFormat)}: {pMessage}{Environment.NewLine}";

            // write data
            File.AppendAllText(Constants.FullPathToLogfile, message);
        }
    }
}
