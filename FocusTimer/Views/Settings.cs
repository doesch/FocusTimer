using FocusTimer.Classes;
using FocusTimer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusTimer
{
    /// <summary>
    /// The main view
    /// </summary>
    public partial class Settings : BaseView
    {
        /// <summary>
        /// Data shared between views
        /// </summary>
        private ITimer m_Timer;
        private IPlayer m_Player;

        public Settings(ITimer pTimer, IPlayer pPlayer)
        {
            m_Timer = pTimer;
            m_Player = pPlayer;

            InitializeComponent();
            Init();
        }

        /// <summary>
        /// initialize
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Init()
        {
            // apply settings

            // Music files
            var fullPathToMusicFiles = SettingsFile.Default.FullPathToMusicFiles;

            // load music files
            LoadMusicFiles(fullPathToMusicFiles);
        }

        /// <summary>
        /// Start focus time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnStart_Click(object sender, EventArgs e)
        {
            // apply start value
            m_Timer.StartValue = (int)inputTime.Value;

            // change view
            ChangeView(ViewsEnum.KeepFocus);
        }

        /// <summary>
        /// Select folder for music
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                // select folder
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    LoadMusicFiles(fbd.SelectedPath);
                }

                // cache selected folder
                SettingsFile.Default.FullPathToMusicFiles = fbd.SelectedPath;
                SettingsFile.Default.Save();
            }
        }

        /// <summary>
        /// Load the music files into the grid and player
        /// </summary>
        /// <param name="pPath"></param>
        private void LoadMusicFiles(string pPath)
        {
            if (pPath != null && Directory.Exists(pPath))
            {
                string[] files = Directory.GetFiles(pPath);

                // clear list
                m_Player.Tracklist.Clear();

                // add files to tracklist
                foreach (var fullPath in files)
                {
                    if (fullPath.EndsWith("mp3")) // filter supported file types
                    {
                        m_Player.Tracklist.Add(new Track(fullPath));
                    }
                }

                // bind data to the grid
                dataGridViewPlayList.DataSource = m_Player.Tracklist;

                // size column width 
                dataGridViewPlayList.AutoResizeColumns();

                // apply selection changed Event
                dataGridViewPlayList.CellClick += new DataGridViewCellEventHandler(OnTrackSelected);

                // select random track
                var rowIndex = new Random().Next(0, dataGridViewPlayList.RowCount - 1);
                dataGridViewPlayList.Rows[rowIndex].Cells[0].Selected = true;
                OnTrackSelected(dataGridViewPlayList, null);
                
            }
        }

        /// <summary>
        /// When track selection has changed in the playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void OnTrackSelected(object sender, EventArgs e)
        {
            // apply selected track
            var dataGridView = (DataGridView)sender;

            if (dataGridView.SelectedCells.Count > 0)
            {
                // find row by cell
                var rowIndex = dataGridView.SelectedCells[0].RowIndex;

                // get track from rable row and assign it as selected track
                m_Player.SelectedTrack = (Track)dataGridView.Rows[rowIndex].DataBoundItem;
            }
        }
    }
}
