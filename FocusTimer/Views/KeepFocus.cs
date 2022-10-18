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

        private void Init()
        {
            // assign handler
            m_Timer.OnTick = OnTick;

            // show init time
            labelCurrentTime.Text = m_Timer.CurrentTime.ToString("hh\\:mm\\:ss");

            // start timer
            m_Timer.Start();
        }

        private void OnTick(object sender, EventArgs e)
        {
            // show time in label
            var timer = (FocusTimer.Classes.Timer)sender;

            // use invoker for threads
            this.Invoke(new MethodInvoker(delegate ()
            {
                labelCurrentTime.Text = m_Timer.CurrentTime.ToString("hh\\:mm\\:ss");
            }));
            
        }

        private void BttnStop_Click(object sender, EventArgs e)
        {
            this.ChangeView(ViewsEnum.End);
        }
    }
}
