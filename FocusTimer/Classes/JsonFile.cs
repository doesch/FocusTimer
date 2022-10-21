using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    /// <summary>
    /// manages the json file
    /// </summary>
    public class JsonFile : IJsonFile
    {
        /// <summary>
        /// The statistics in json file
        /// </summary>
        public IStatistics Statistics { get; set; }

        /// <summary>
        /// The json file
        /// </summary>
        public JsonFile()
        {
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
            string json = JsonSerializer.Serialize(Statistics);
            File.WriteAllText(Constants.FullPathToJsonFile, String.Empty); // clear file
            File.WriteAllText(Constants.FullPathToJsonFile, json); // write data
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
            }
        }
    }
}
