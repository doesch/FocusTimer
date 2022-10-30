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
    public partial class Break : BaseView
    {
        IBreakTimer m_BreakTimer;
        private IJsonFile m_JsonFile; // statistics
        private IFocusTimer m_Timer;

        public Break(IBreakTimer pBreakTimer, IJsonFile pJsonFile, IFocusTimer timer)
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
            // apply eventhandler
            m_BreakTimer.OnTick = new EventHandler(OnTick);

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
        private void OnTick(object? sender, EventArgs e)
        {
            // show time in label
            var timer = (BreakTimer)sender;

            // use invoker for threads
            RenderTime(timer);

            // save stats
            SaveStats(timer);
        }

        /// <summary>
        /// Save statistics
        /// </summary>
        /// <param name="pBreakTimer"></param>
        private void SaveStats(IBreakTimer pBreakTimer)
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
        private void RenderTime(IBreakTimer pTimer)
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
    }
}
