using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    /// <summary>
    /// Player plays music
    /// </summary>
    public class Player : IPlayer
    {
        /// <summary>
        /// All tracks
        /// </summary>
        public List<ITrack> Tracklist { get; set; } = new List<ITrack>();

        /// <summary>
        /// Selected Track
        /// </summary>
        public ITrack SelectedTrack { get; set; }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
