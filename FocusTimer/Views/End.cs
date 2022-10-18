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
    public partial class End : BaseView
    {
        public End()
        {
            InitializeComponent();
        }

        private void bttnStartBreak_Click(object sender, EventArgs e)
        {
            this.ChangeView(ViewsEnum.Break);
        }
    }
}
