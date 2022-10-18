using NAudio.Wave;
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
        /// <summary> The player. </summary>
        private static WaveOut m_Player;

        public static Mp3FileReader Reader { get; private set; }

        /// <summary>
        /// All tracks
        /// </summary>
        public List<ITrack> Tracklist { get; set; } = new List<ITrack>();

        /// <summary>
        /// Selected Track
        /// </summary>
        public ITrack SelectedTrack { get; set; }

        /// <summary>
        /// caches the path of the track that is currently loaded in the player
        /// </summary>
        private string m_CurrentTrackInPlayer { get; set; }

        /// <summary>
        /// Pause Music
        /// </summary>
        public void Pause()
        {
            if (m_Player != null)
            {
                m_Player.Pause();
            }
        }

        /// <summary>
        /// Play music
        /// </summary>
        public void Play()
        {
            // play new song, when path has changed, else continue current selected (pause release)
            if (SelectedTrack.FullPath != m_CurrentTrackInPlayer)
            {
                Reader = new Mp3FileReader(SelectedTrack.FullPath);
                m_Player = new WaveOut();
                m_Player.Init(Reader);

                // cache the latest selected patch
                m_CurrentTrackInPlayer = SelectedTrack.FullPath;
            }

            m_Player.Play();
        }

        /// <summary>
        /// Stop playing music
        /// </summary>
        public void Stop()
        {
            if (m_Player != null && m_Player.PlaybackState == PlaybackState.Playing)
            {
                m_Player.Stop();
                m_Player.Dispose();
                Reader.Dispose();
            }
        }
    }
}
