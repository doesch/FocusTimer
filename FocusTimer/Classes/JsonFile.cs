using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    /// <summary>
    /// manages the json file
    /// </summary>
    public class JsonFileService : IJsonFileService
    {
        /// <summary>
        /// The statistics in json file
        /// </summary>
        public IStatistics? Statistics { get; set; }

        /// <summary>
        /// the loggerservice
        /// </summary>
        private ILoggerService m_LoggerService;

        /// <summary>
        /// The json file
        /// </summary>
        public JsonFileService(ILoggerService pLoggerService)
        {
            // inject logger
            m_LoggerService = pLoggerService;
            Init();
        }

        /// <summary>
        /// Inits the class
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Init()
        {
            // create file and directory if not exists
            if (!File.Exists(Constants.FullPathToJsonFile))
            {
                // create directory if not exists
                var directory = Path.GetDirectoryName(Constants.FullPathToJsonFile);

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // export empty statistics shema
                Statistics = new  Statistics();
                Export();
            }
            else
            {
                Import();
            }
        }

        /// <summary>
        /// Export all statistics
        /// </summary>
        /// <param name="pStatistics"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Export()
        {
            if (Statistics != null)
            {
                string json = JsonSerializer.Serialize(Statistics);
                File.WriteAllText(Constants.FullPathToJsonFile, String.Empty); // clear file
                File.WriteAllText(Constants.FullPathToJsonFile, json); // write data

                // log
                m_LoggerService.Log($"Current Day Focus Time: {Statistics.CurrentDay.FocusTime.ToString(Constants.cDisplayTimeFormatShort)}");
            }
        }

        /// <summary>
        /// Load all Statistics
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Import()
        {
            using (FileStream stream = File.OpenRead(Constants.FullPathToJsonFile))
            {
                Statistics = JsonSerializer.Deserialize<Statistics>(stream);

                // log starting the app
                m_LoggerService.Log("----- App started -----");
                m_LoggerService.Log($"Imported Current Day Focus Time: {Statistics.CurrentDay.FocusTime.ToString(Constants.cDisplayTimeFormatShort)}");
            }
        }
    }
}
