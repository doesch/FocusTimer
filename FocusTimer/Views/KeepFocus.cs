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
        private ITimer m_Timer;
        private IPlayer m_Player;

        /// <summary>
        /// run focus time
        /// </summary>
        /// <param name="pTime"></param>
        /// <param name="pSelectedTrack"></param>
        public KeepFocus(ITimer pTimer, IPlayer pPlayer)
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
            // assign handler
            m_Timer.OnTick = OnTick;

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
        private void OnTick(object sender, EventArgs e)
        {
            // show time in label
            var timer = (FocusTimer.Classes.Timer)sender;

            // use invoker for threads
            this.Invoke(new MethodInvoker(delegate ()
            {
                RenderTime(timer);
            }));
            
        }

        /// <summary>
        /// Display the time
        /// </summary>
        /// <param name="timer"></param>
        private void RenderTime(ITimer pTimer)
        {
            labelCurrentTime.Text = pTimer.CurrentTime.ToString("hh\\:mm\\:ss");
        }

        /// <summary>
        /// When user stopped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BttnStop_Click(object sender, EventArgs e)
        {
            this.m_Timer.Stop();
            this.ChangeView(ViewsEnum.End);
        }
    }
}
