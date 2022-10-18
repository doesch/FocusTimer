using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Classes
{
    public interface IPlayer
    {
        public ITrack Track { get; set; }

        public void Start();

        public void Stop();

        public void Pause();
    }
}
