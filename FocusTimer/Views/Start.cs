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
    public partial class Start : BaseView
    {
        public Start()
        {
            InitializeComponent();
        }

        private void bttnStartFocusTime_Click(object sender, EventArgs e)
        {
            this.ChangeView(ViewsEnum.KeepFocus);
        }

        private void linkLabelSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ChangeView(ViewsEnum.Settings);
        }

        private void labelMainText_Click(object sender, EventArgs e)
        {

        }
    }
}
