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
    public partial class Break : BaseView
    {
        IBreakTimerService m_BreakTimer;
        private IJsonFileService m_JsonFile; // statistics
        private IFocusTimerService m_Timer;

        public Break(IBreakTimerService pBreakTimer, IJsonFileService pJsonFile, IFocusTimerService timer)
        {
            m_BreakTimer = pBreakTimer;
            m_JsonFile = pJsonFile;
            m_Timer = timer;
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Init the view
        /// </summary>
        private void Init()
        {
            // apply dispose event handler
            Disposed += OnDispose;

            // apply eventhandler
            m_BreakTimer.Tick += BreakTimer_Tick;

            // start timer
            m_BreakTimer.Start();

            // show init value
            RenderTime(m_BreakTimer);

            // show focus time of the day
            labelCurrentFocusTimeOfTheDay.Text = $"Your total focus time for today is: {m_JsonFile.Statistics.CurrentDay.FocusTime.ToString(Constants.cDisplayTimeFormatShort)}";
        }

        /// <summary>
        /// Breaktimer tick eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BreakTimer_Tick(object? sender, EventArgs e)
        {
            if (sender == null) return;

            // show time in label
            var timer = (BreakTimerService)sender;

            // use invoker for threads
            RenderTime(timer);

            // save stats
            SaveStats(timer);
        }

        /// <summary>
        /// Save statistics
        /// </summary>
        /// <param name="pBreakTimer"></param>
        private void SaveStats(IBreakTimerService pBreakTimer)
        {
            if (pBreakTimer.CurrentTime.Seconds == 0)
            {
                // Save every minute of focus time
                m_JsonFile.Statistics.CurrentDay.BreakTime += TimeSpan.FromMinutes(1);
                m_JsonFile.Export();
            }
        }

        /// <summary>
        /// Renders the time in the view
        /// </summary>
        /// <param name="pTimer"></param>
        private void RenderTime(IBreakTimerService pTimer)
        {
            if (this.labelCurrentTime.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    labelCurrentTime.Text = pTimer.CurrentTime.ToString("hh\\:mm\\:ss");
                }));
            }
            else
            {
                labelCurrentTime.Text = pTimer.CurrentTime.ToString("hh\\:mm\\:ss");
            }
        }

        /// <summary>
        /// User wants to continue with focus time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnStartFocusTime_Click(object sender, EventArgs e)
        {
            // apply start time for focus time from settings
            m_Timer.StartValue = SettingsFile.Default.StartValue;

            this.ChangeView(ViewsEnum.KeepFocus);
        }

        private void linkLabelStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ChangeView(ViewsEnum.Start);
        }

        /// <summary>
        /// dispose
        /// </summary>
        private void OnDispose(object sender, EventArgs e)
        {
            // remove events
            m_BreakTimer.Tick -= BreakTimer_Tick;
        }
    }
}
