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

        public Break(IBreakTimer pBreakTimer)
        {
            m_BreakTimer = pBreakTimer;
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
            this.ChangeView(ViewsEnum.KeepFocus);
        }

        /// <summary>
        /// User wants to go to the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ChangeView(ViewsEnum.Settings);
        }
    }
}
