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

        /// <summary>
        /// Gets/Sets the volume
        /// </summary>
        public float Volume
        {
            get
            {
                return m_Player != null ? m_Player.Volume : 1;
            }
            set
            {
                if (m_Player != null)
                {
                    m_Player.Volume = value;
                }
            } 
        }

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

            // play new song, when path has changed or latest track has end, else continue current selected (pause release)
            if (SelectedTrack.FullPath != m_CurrentTrackInPlayer || m_Player.PlaybackState == PlaybackState.Stopped)
            {
                // destroy old instance
                if (m_Player != null)
                {
                    m_Player.Dispose();
                }

                if (m_Reader != null)
                {
                    m_Reader.Dispose();
                }

                // create new instance with selected track
                try
                {
                    m_Reader = new Mp3FileReader(SelectedTrack.FullPath);
                }
                catch (InvalidDataException)
                {
                    MessageBox.Show("Invalid File.", "Cannot play music.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                
                m_Player = new WaveOut();
                m_Player.PlaybackStopped += new EventHandler<NAudio.Wave.StoppedEventArgs>(OnPlayBackStopped);
                m_Player.Init(m_Reader);

                // cache the latest selected patch
                m_CurrentTrackInPlayer = SelectedTrack.FullPath;
            }

            m_Player.Play();
        }

        /// <summary>
        /// Eventhandler that fires when the music ends.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void OnPlayBackStopped(object? sender, EventArgs e)
        {
            // play next random track
            Stop();
            SelectRandomTrack();
            Play();
        }

        /// <summary>
        /// Stop playing music
        /// </summary>
        public void Stop()
        {
            if (m_Player != null)
            {
                m_Player.Stop();
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
                var index = new Random().Next(0, Tracklist.Count);
                SelectedTrack = Tracklist[index];
            }
            else if (Tracklist.Count == 1)
            {
                SelectedTrack = Tracklist[0];
            }
            else
            {
                // there is no track in the list
                SelectedTrack = null;
            }
        }
    }
}
