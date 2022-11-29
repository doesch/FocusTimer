using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Services
{
    public interface IFocusTimerService
    {
        // the value in Minutes
        public int StartValue { set; }

        public TimeSpan CurrentTime { get; }

        void Start();

        void Stop();

        /// <summary>
        /// Eventhandler which fires every 1 second
        /// </summary>
        public event EventHandler? Tick;

        /// <summary>
        /// Eventhandler which fires when timer ends
        /// </summary>
        public event EventHandler? End;
    }
}
