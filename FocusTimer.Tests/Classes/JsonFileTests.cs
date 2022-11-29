using FluentAssertions;
using FocusTimer.Services;

namespace FocusTimer_Tests.Classes
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {            
        }

        /// <summary>
        /// cleanup
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            // delete the database if exists
            DeleteJsonFile();
        }

        /// <summary>
        /// Delete the database if exists
        /// </summary>
        private void DeleteJsonFile()
        {
            // delete the database
            if (File.Exists(Constants.FullPathToJsonFile))
            {
                File.Delete(Constants.FullPathToJsonFile);
            }
        }

        /// <summary>
        /// Tests if the values of the daily focus time will be saved in the json file correctly
        /// </summary>
        [Test]
        public void IncreaseFocusTime()
        {
            // Arrange
            DeleteJsonFile(); // delete the json file if exists
            var loggerService = new LoggerService(Constants.FullPathToLogfile);
            var jsonFile = new JsonFileService(loggerService);
            var minutes1 = 25;
            var minutes2 = 5;
            var expectedValue = new TimeSpan();
            expectedValue += TimeSpan.FromMinutes(minutes1 + minutes2); // the expected value

            // Act
            jsonFile.Statistics.CurrentDay.FocusTime += TimeSpan.FromMinutes(minutes1);
            jsonFile.Export();
            
            // add additional time
            jsonFile.Statistics.CurrentDay.FocusTime += TimeSpan.FromMinutes(minutes2);
            jsonFile.Export();

            // import jsonFile and fill the data into the cache
            jsonFile.Import();

            // Assert
            jsonFile.Statistics.CurrentDay.FocusTime.Should().Be(expectedValue);
        }
    }
}