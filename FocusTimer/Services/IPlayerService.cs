using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    /// <summary>
    /// The player
    /// </summary>
    public interface IPlayerService
    {
        /// <summary>
        /// The tracklist
        /// </summary>
        public List<ITrack> Tracklist { get; set; }

        /// <summary>
        /// The selected Track
        /// </summary>
        public ITrack SelectedTrack { get; set; }
        float Volume { get; set; }

        public void Play();

        public void Stop();

        public void Pause();
        void LoadPlaylist(string selectedPath);
        void SelectRandomTrack();
    }
}
