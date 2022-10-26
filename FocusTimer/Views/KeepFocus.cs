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
using FocusTimer.Classes;

namespace FocusTimer
{
    /// <summary>
    /// The view where the user keeps focus
    /// </summary>
    public partial class KeepFocus : BaseView
    {
        private IFocusTimer m_Timer;
        private IPlayer m_Player;
        private IJsonFile m_JsonFile; // statistics

        /// <summary>
        /// run focus time
        /// </summary>
        /// <param name="pTime"></param>
        /// <param name="pSelectedTrack"></param>
        public KeepFocus(IFocusTimer pTimer, IPlayer pPlayer, IJsonFile pJsonFile)
        {
            m_Timer = pTimer;
            m_Player = pPlayer;
            m_JsonFile = pJsonFile;
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// Init view
        /// </summary>
        private void Init()
        {
            // play music
            m_Player.Play();

            // assign handler
            m_Timer.OnTick = OnTick;            
            m_Timer.OnEnd = OnEnd;

            // start timer
            m_Timer.Start();

            // display init time
            RenderTime(m_Timer);
        }

        /// <summary>
        /// An Tick-Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTick(object? sender, EventArgs e)
        {
            // show time in label
            var timer = (FocusTimer.Classes.FocusTimer)sender;

            // use invoker for threads
            RenderTime(timer);

            // save stats
            SaveStats(timer);
        }

        /// <summary>
        /// Save statistics
        /// </summary>
        private void SaveStats(IFocusTimer pFocusTimer)
        {
            if (pFocusTimer.CurrentTime.Seconds == 0)
            {
                // Save every minute of focus time
                m_JsonFile.Statistics.CurrentDay.FocusTime += TimeSpan.FromMinutes(1);
                m_JsonFile.Export();
            }
        }

        /// <summary>
        /// Handler when timer ends
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void OnEnd(object? sender, EventArgs e)
        {
            // keep timer running to calculate the overtime
            // stop timer
            m_Timer.Stop();
            
            ChangeView(ViewsEnum.End);
        }

        /// <summary>
        /// Display the time
        /// </summary>
        /// <param name="timer"></param>
        private void RenderTime(IFocusTimer pTimer)
        {
            if (this.labelCurrentTime.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    labelCurrentTime.Text = pTimer.CurrentTime.ToString(Constants.cDisplayTimeFormat);
                }));
            }
            else
            {
                labelCurrentTime.Text = pTimer.CurrentTime.ToString(Constants.cDisplayTimeFormat);
            }
        }

        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // stop music
            this.m_Player.Pause();

            // stop timer
            this.m_Timer.Stop();

            // go to settings view
            this.ChangeView(ViewsEnum.Start);
        }

        private void BttnMain_Click(object sender, EventArgs e)
        {
            // stop music
            this.m_Player.Pause();

            // stop timer
            this.m_Timer.Stop();

            // go to settings view
            this.ChangeView(ViewsEnum.Break);
        }

        /// <summary>
        /// Silder changes the volume
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volumeValueChanged(object sender, EventArgs e)
        {
            float value = 1 / (float)trackBarVolume.Maximum * (float)trackBarVolume.Value;
            m_Player.Volume = value;
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {

        }

        private void linkLabelNextTrack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // play the next track
            m_Player.Stop();
            m_Player.SelectRandomTrack();
            m_Player.Play();
        }
    }
}
