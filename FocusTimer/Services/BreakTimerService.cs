using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FocusTimer.Services
{
    public class BreakTimerService : IBreakTimerService
    {
        /// <summary>
        /// The native timer
        /// </summary>
        private System.Timers.Timer m_Timer = new System.Timers.Timer();

        /// <summary>
        /// The current time
        /// </summary>
        public TimeSpan CurrentTime { get; private set; } = default(TimeSpan);

        /// <summary>
        /// Set an eventhandler from outside
        /// </summary>
        public event EventHandler Tick;

        /// <summary>
        /// constructor
        /// </summary>
        public BreakTimerService() 
        {
            // init .NET timer object
            m_Timer.Interval = 1000; // event fires every 1000 milliseconds
            m_Timer.Enabled = true;
            m_Timer.Elapsed += BreakTimer_Tick;
        }

        /// <summary>
        /// Start the timer
        /// </summary>
        public void Start()
        {
            // set start value
            CurrentTime = default(TimeSpan); // reset time

            // start timer
            m_Timer.Start();
        }

        /// <summary>
        /// Stops the timer
        /// </summary>
        public void Stop()
        {
            m_Timer.Stop();
        }

        /// <summary>
        /// Event that fires every 1000 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BreakTimer_Tick(object? sender, EventArgs e)
        {
            // deduct 1 second from time
            CurrentTime += TimeSpan.FromSeconds(1);

            // execute events
            Tick?.Invoke(this, e);
        }
    }
}
