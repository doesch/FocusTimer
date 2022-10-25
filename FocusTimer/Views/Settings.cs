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
        private IFocusTimer m_Timer;
        private IPlayer m_Player;

        public Settings(IFocusTimer pTimer, IPlayer pPlayer)
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
            // apply start time for focus time from settings
            inputTime.Value = SettingsFile.Default.StartValue;

            // Render datagrid
            RenderPlayList();
        }

        /// <summary>
        /// Start focus time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnStart_Click(object sender, EventArgs e)
        {
            SaveChanges();

            // change view
            ChangeView(ViewsEnum.KeepFocus);
        }

        /// <summary>
        /// save the changes
        /// </summary>
        private void SaveChanges()
        {
            var startValue = (int)inputTime.Value;

            // apply start value
            m_Timer.StartValue = startValue;

            // save selected time in settings
            SettingsFile.Default.StartValue = startValue;
            SettingsFile.Default.Save();
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
                    m_Player.LoadPlaylist(fbd.SelectedPath);
                    RenderPlayList();
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
        private void RenderPlayList()
        {
            //  clear datasource
            dataGridViewPlayList.DataSource = null;

            // bind data to the grid
            dataGridViewPlayList.DataSource = m_Player.Tracklist;

            // apply selection changed Event
            dataGridViewPlayList.CellClick += new DataGridViewCellEventHandler(OnTrackSelected);

            // mark current selected track in grid
            if (m_Player.SelectedTrack != null)
            {
                for (int i = 0; i < dataGridViewPlayList.Rows.Count; i++)
                {
                    var track = (ITrack)dataGridViewPlayList.Rows[i].DataBoundItem;

                    // select or deselect
                    dataGridViewPlayList.Rows[i].Selected = track.FullPath == m_Player.SelectedTrack.FullPath; // row

                    try
                    {
                        // I don´t know why I need this try-catch. It sometimes occurs when I select another folder as playlist
                        dataGridViewPlayList.Rows[i].Cells[0].Selected = track.FullPath == m_Player.SelectedTrack.FullPath; // cell
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        continue;
                    }          
                }
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
                // I don´t know why I need to use this try - catch
                try
                {
                    // find row by cell
                    var rowIndex = dataGridView.SelectedCells[0].RowIndex;

                    // get track from rable row and assign it as selected track
                    m_Player.SelectedTrack = (Track)dataGridView.Rows[rowIndex].DataBoundItem;
                }
                catch (System.IndexOutOfRangeException)
                {
                    // do nothing
                }
            }
        }

        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveChanges();

            ChangeView(ViewsEnum.Start);
        }
    }
}
