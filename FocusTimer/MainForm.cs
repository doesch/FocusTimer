using FocusTimer.Classes;
using FocusTimer.Views;

namespace FocusTimer
{
    /// <summary>
    /// The main form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Shares data between all views
        /// </summary>
        private static ITimer m_Timer = new Classes.Timer();
        private static IPlayer m_Player = new Player();

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            // load init view
            LoadView(ViewsEnum.Settings);            
        }

        /// <summary>
        /// load main view
        /// </summary>
        /// <param name="pControl"></param>
        private void LoadView(ViewsEnum pView)
        {
            BaseView view;

            /// convert enum into view
            switch (pView)
            {
                case ViewsEnum.Settings:
                    view = new Settings(m_Timer, m_Player);
                    break;
                case ViewsEnum.KeepFocus:
                    view = new KeepFocus(m_Timer, m_Player);
                    break;
                case ViewsEnum.End:
                    view = new End(m_Timer, m_Player);
                    break;
                case ViewsEnum.Break:
                    view = new Break();
                    break;
                case ViewsEnum.Stats:
                    view = new Stats();
                    break;
                default:
                    view = new Settings(m_Timer, m_Player);
                    break;
            }

            // assign event handler
            view.OnViewChanged += new EventHandler(OnViewChanged);

            // load the control
            if (this.mainLayoutPanel.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    LoadView(view);
                }));
            }
            else
            {
                LoadView(view);
            }
        }

        /// <summary>
        /// load the view
        /// </summary>
        /// <param name="pView"></param>
        private void LoadView(BaseView pView)
        {
            mainLayoutPanel.Controls.Clear();
            mainLayoutPanel.Controls.Add(pView);
        }

        /// <summary>
        /// UserControl has fired an event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnViewChanged(object? sender, EventArgs e)
        {
            var viewBase = (BaseView)sender;
            LoadView(viewBase.NextView);
        }
    }
}