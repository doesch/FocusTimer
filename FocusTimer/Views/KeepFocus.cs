﻿using FocusTimer.Views;
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

        /// <summary>
        /// run focus time
        /// </summary>
        /// <param name="pTime"></param>
        /// <param name="pSelectedTrack"></param>
        public KeepFocus(IFocusTimer pTimer, IPlayer pPlayer)
        {
            m_Timer = pTimer;
            m_Player = pPlayer;
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

            // Play the alarm
            Player.PlayAlarm();
            
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
                    labelCurrentTime.Text = pTimer.CurrentTime.ToString(Constants.DisplayTimeFormat);
                }));
            }
            else
            {
                labelCurrentTime.Text = pTimer.CurrentTime.ToString(Constants.DisplayTimeFormat);
            }
        }

        /// <summary>
        /// When user stopped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BttnStop_Click(object sender, EventArgs e)
        {
            // stop music
            this.m_Player.Pause();

            // stop timer
            this.m_Timer.Stop();

            // go to settings view
            this.ChangeView(ViewsEnum.Start);
        }

        /// <summary>
        /// When user wants to make abreak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelBreak_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // stop music
            this.m_Player.Pause();

            // stop timer
            this.m_Timer.Stop();

            // go to settings view
            this.ChangeView(ViewsEnum.Break);
        }
    }
}
