using FocusTimer.Services;
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
    /// <summary>
    /// Shows the statistics
    /// </summary>
    public partial class Statistics : BaseView
    {
        private IJsonFileService m_JsonFile;

        public Statistics(IJsonFileService pJsonFile)
        {
            m_JsonFile = pJsonFile;
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// init the component
        /// </summary>
        private void Init()
        {
            if (m_JsonFile.Statistics.AllDays.Count > 0)
            {
                // bind datagrid
                dataGridViewStatistics.DataSource = null;
                dataGridViewStatistics.DataSource = m_JsonFile.Statistics.AllDays.OrderByDescending(x => x.DateTimeUtc).ToList(); // tolist is required, because hashset is not working with datagrid
                dataGridViewStatistics.AutoResizeColumns();
            }
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelStartPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeView(ViewsEnum.Start);
        }

        private void bttnStartFocusTime_Click(object sender, EventArgs e)
        {
            ChangeView(ViewsEnum.KeepFocus);
        }
    }
}
