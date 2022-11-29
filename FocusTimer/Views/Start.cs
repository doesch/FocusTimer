using FocusTimer.Services;
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
    public partial class Start : BaseView
    {
        private IJsonFileService m_JsonFile;
        private IFocusTimerService m_Timer;

        public Start(IJsonFileService pJsonFile, IFocusTimerService timer)
        {
            m_JsonFile = pJsonFile;
            m_Timer = timer;
            InitializeComponent();
            Init();            
        }

        /// <summary>
        /// init view
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Init()
        {
            // display statistic
            labelCurrentTime.Text = m_JsonFile.Statistics.CurrentDay.FocusTime.ToString(Constants.cDisplayTimeFormatShort);
        }

        private void bttnStartFocusTime_Click(object sender, EventArgs e)
        {
            // apply start time for focus time from settings
            m_Timer.StartValue = SettingsFile.Default.StartValue;
            this.ChangeView(ViewsEnum.KeepFocus);
        }


        private void labelMainText_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ChangeView(ViewsEnum.Settings);
        }
    }
}
