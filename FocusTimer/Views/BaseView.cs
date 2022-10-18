using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusTimer.Views
{
    /// <summary>
    /// define all views here
    /// </summary>
    public enum ViewsEnum
    {
        Start,
        Settings,
        KeepFocus,
        End,
        Break,
        Stats
    }

    /// <summary>
    /// base class for all views
    /// </summary>
    public class BaseView : UserControl
    {
        // eventhander for all views what happens when the view changes
        public event EventHandler OnViewChanged;

        // caches the next view
        public ViewsEnum NextView;

        /// <summary>
        /// changes the view
        /// </summary>
        /// <param name="pControl"></param>
        protected void ChangeView(ViewsEnum pNextView)
        {
            NextView = pNextView;
            if (OnViewChanged != null)
            {
                OnViewChanged(this, null);
            }
        }
    }
}
