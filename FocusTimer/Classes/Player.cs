using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
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

        private static Mp3FileReader m_Reader;

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

        // the alarm, which will be trigged when the focus time is over
        private static SoundPlayer Alarm = new SoundPlayer(Path.Combine(Environment.CurrentDirectory, @"SoundFiles\", "582597__nezuai__ui-sound-2.wav"));

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
            // check if track is selected
            if (SelectedTrack == null)
            {
                return;
            }

            // play new song, when path has changed, else continue current selected (pause release)
            if (SelectedTrack.FullPath != m_CurrentTrackInPlayer)
            {
                m_Reader = new Mp3FileReader(SelectedTrack.FullPath);
                m_Player = new WaveOut();
                m_Player.Init(m_Reader);

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
                m_Reader.Dispose();
            }
        }

        /// <summary>
        /// Play alarm sound
        /// </summary>
        public static void PlayAlarm()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Alarm.Play();
                    Thread.Sleep(1250);
                }
            }).Start();
        }

        /// <summary>
        /// Load Playlist
        /// </summary>
        /// <param name="selectedPath"></param>
        public void LoadPlaylist(string pSelectedPath)
        {
            if (pSelectedPath != null && Directory.Exists(pSelectedPath))
            {
                string[] files = Directory.GetFiles(pSelectedPath);

                // clear list
                this.Tracklist.Clear();

                // add files to tracklist
                foreach (var fullPath in files)
                {
                    if (fullPath.EndsWith("mp3")) // filter supported file types
                    {
                        this.Tracklist.Add(new Track(fullPath));
                    }
                }
            }

            SelectRandomTrack();
        }

        /// <summary>
        /// selects an random track
        /// </summary>
        public void SelectRandomTrack()
        {
            // select random track
            if (Tracklist.Count > 1)
            {
                var index = new Random().Next(0, Tracklist.Count - 1);
                SelectedTrack = Tracklist[index];
            }
            else if (Tracklist.Count == 1)
            {
                SelectedTrack = Tracklist[0];
            }
            else
            {
                SelectedTrack = null;
            }
        }
    }
}
