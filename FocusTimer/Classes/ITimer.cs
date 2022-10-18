using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    public interface ITimer
    {
        // the value in Minutes
        public int StartValue { set; }

        public TimeSpan CurrentTime { get; }

        void Start();

        void Stop();

        void Pause();

        /// <summary>
        /// Eventhandler which fires every 1 second
        /// </summary>
        public EventHandler OnTick { set; get; }

        /// <summary>
        /// Eventhandler which fires when timer ends
        /// </summary>
        public EventHandler OnEnd { set; get; }
    }
}
