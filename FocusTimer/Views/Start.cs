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
    public partial class Start : BaseView
    {
        private IJsonFile m_JsonFile;

        public Start(IJsonFile pJsonFile)
        {
            m_JsonFile = pJsonFile;
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// init view
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Init()
        {
            // display statistic
            labelCurrentTime.Text = m_JsonFile.Statistics.CurrentDay.FocusTime.ToString(Constants.cDisplayTimeFormat);
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
