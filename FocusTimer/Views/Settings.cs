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
    }
}
