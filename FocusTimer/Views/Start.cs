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
            // display current´s days statistic
            labelCurrentTime.Text = m_JsonFile.Statistics.CurrentDay.FocusTime.ToString(Constants.cDisplayTimeFormatShort);

            // show yesterday´s statistic
            var focusTimeYesterday = m_JsonFile.Statistics.AllDays.OrderByDescending(d => d.DateTimeUtc).First().FocusTime.ToString(Constants.cDisplayTimeFormatShort);
            labelLastFocusTime.Text = $"Your last focus time was: {focusTimeYesterday}";
        }

        private void bttnStartFocusTime_Click(object sender, EventArgs e)
        {
            this.ChangeView(ViewsEnum.KeepFocus);
        }
        private void labelMainText_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ChangeView(ViewsEnum.Settings);
        }

        private void linkLabelStatistics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ChangeView(ViewsEnum.Statistics);
        }
    }
}
