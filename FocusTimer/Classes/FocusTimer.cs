using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FocusTimer.Classes
{
    public class FocusTimer : IFocusTimer
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
        public event EventHandler? Tick;

        /// <summary>
        /// When finishes
        /// </summary>
        public event EventHandler? End;

        /// <summary>
        /// constructor
        /// </summary>
        public FocusTimer() 
        {
            // init .NET timer object
            m_Timer.Interval = 1000; // event fires every 1000 seconds
            m_Timer.Enabled = true;
            m_Timer.Elapsed += OnTimerTick;
        }

        /// <summary>
        /// Start the timer
        /// </summary>
        public void Start()
        {
            // set start value
            CurrentTime = default(TimeSpan); // reset time
            CurrentTime += TimeSpan.FromMinutes(StartValue);

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
        private void OnTimerTick(object? sender, EventArgs e)
        {
            // deduct 1 second from time
            CurrentTime -= TimeSpan.FromSeconds(1);

            // execute events
            Tick?.Invoke(this, e);

            // execute event, when timer ran out (finished)
            if (CurrentTime <= default(TimeSpan))
            {
                End?.Invoke(this, e);
            }
        }
    }
}
