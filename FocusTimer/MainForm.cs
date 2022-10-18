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
        private static IFocusTimer m_Timer = new Classes.FocusTimer();
        private static IPlayer m_Player = new Player();

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            // apply start time for focus time from settings
            m_Timer.StartValue = SettingsFile.Default.StartValue;

            // load playlist
            var path = SettingsFile.Default.FullPathToMusicFiles;
            if (!String.IsNullOrWhiteSpace(path) && Directory.Exists(path))
            {
                m_Player.LoadPlaylist(path);
            }

            // select random track in player
            m_Player.SelectRandomTrack();

            // load init view
            LoadView(ViewsEnum.Start);            
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
                case ViewsEnum.Start:
                    view = new Start();
                    break;
                case ViewsEnum.Settings:
                    view = new Settings(m_Timer, m_Player);
                    break;
                case ViewsEnum.KeepFocus:
                    view = new KeepFocus(m_Timer, m_Player);
                    // minimize window
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case ViewsEnum.End:
                    view = new End(m_Timer, m_Player);
                    // show window (if minimized)
                    if (this.WindowState != FormWindowState.Normal)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }                    
                    break;
                case ViewsEnum.Break:
                    view = new Break(new BreakTimer());
                    break;
                case ViewsEnum.Stats:
                    view = new Start();
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