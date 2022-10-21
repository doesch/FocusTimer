using FocusTimer.Classes;
using FocusTimer.Views;
using System.Reflection;

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
        private static IJsonFile m_JsonFile = new JsonFile();

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            // load playlist
            var path = SettingsFile.Default.FullPathToMusicFiles;
            if (!String.IsNullOrWhiteSpace(path) && Directory.Exists(path))
            {
                m_Player.LoadPlaylist(path);
            }

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
                    view = new Start(m_JsonFile, m_Timer);
                    break;
                case ViewsEnum.Settings:
                    view = new Settings(m_Timer, m_Player);
                    break;
                case ViewsEnum.KeepFocus:
                    view = new KeepFocus(m_Timer, m_Player, m_JsonFile);
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
                    view = new Break(new BreakTimer(), m_JsonFile, m_Timer);
                    break;
                default:
                    view = new Start(m_JsonFile, m_Timer);
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

        /// <summary>
        /// When window is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            // save window position
            SettingsFile.Default.WindowLocation = Location;
            SettingsFile.Default.Save();
        }

        /// <summary>
        /// When form is loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            // set window to latest position

            var location = SettingsFile.Default.WindowLocation;

            // when window is out of screenview, then put window into screenview
            if (location.X < 0 || location.Y < 0)
            {
                // put window into sceen position
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(0, 0);
            }
            else
            {
                Location = location;
            }
        }
    }
}