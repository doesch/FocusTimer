using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FocusTimer.Classes
{
    public class Timer : ITimer
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
        /// The start value in minutes
        /// </summary>
        public int StartValue { set; get; }

        /// <summary>
        /// Set an eventhandler from outside
        /// </summary>
        public EventHandler OnTick { set; get; }

        /// <summary>
        /// When finishes
        /// </summary>
        public EventHandler OnEnd { set; get; }

        public Timer()
        {

        }

        public void Pause()
        {

        }

        /// <summary>
        /// Start the timer
        /// </summary>
        public void Start()
        {
            // init .NET timer object
            m_Timer.Interval = 1000; // event fires every 1000 seconds
            m_Timer.Enabled = true;
            m_Timer.Elapsed += new ElapsedEventHandler(OnTimerTick);

            // set start value
            CurrentTime = default(TimeSpan); // reset time
            CurrentTime += TimeSpan.FromMinutes(25);

            // start timer
            m_Timer.Start();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Event that fires every 1000 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimerTick(object sender, EventArgs e)
        {
            // deduct 1 second from time
            CurrentTime -= TimeSpan.FromSeconds(1);

            // execute events
            if (OnTick != null)
            {
                OnTick(this, null);
            }

            // execute event, when timer ran out (finished)
            if (OnEnd != null && CurrentTime <= default(TimeSpan))
            {
                OnEnd(this, null);
            }
        }
    }
}
