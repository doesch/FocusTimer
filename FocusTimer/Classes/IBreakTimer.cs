using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    public interface IBreakTimer
    {
        public TimeSpan CurrentTime { get; }

        void Start();

        void Stop();

        /// <summary>
        /// Eventhandler which fires every 1 second
        /// </summary>
        public event EventHandler Tick;
    }
}
