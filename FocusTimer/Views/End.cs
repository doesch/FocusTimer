using FocusTimer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusTimer.Views
{


    public partial class End : BaseView
    {
        private ITimer m_Timer;
        private IPlayer m_Player;

        public End(ITimer pTimer, IPlayer pPlayer)
        {
            m_Timer = pTimer;
            m_Player = pPlayer;
            InitializeComponent();
        }

        private void bttnStartBreak_Click(object sender, EventArgs e)
        {
            this.ChangeView(ViewsEnum.Break);
        }

        /// <summary>
        /// Continue focus time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnContinueFocusTime_Click(object sender, EventArgs e)
        {
            // snooze 5 Minutes
            m_Timer.StartValue = 5;

            // continue focus time
            this.ChangeView(ViewsEnum.KeepFocus);
        }

        /// <summary>
        /// Go to the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_Player.Pause();

            this.ChangeView(ViewsEnum.Settings);
        }
    }
}
