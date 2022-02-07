namespace CiscoClientHelper
{
    public partial class MainForm : Form
    {   
        private readonly ContextMenuStrip contextMenuStrip;
        private readonly ToolStripMenuItem exitMenuItem;
        private readonly ToolStripMenuItem openMenuItem;

        private readonly AppSettingsService _appSettingsService;

        private readonly SettingsForm _settingsForm;

        public MainForm(AppSettingsService appSettingsService, SettingsForm settingsForm)
        {
            InitializeComponent();
            _appSettingsService = appSettingsService;
            _settingsForm = settingsForm;
            Text = Strings.MainFormTitle;
            contextMenuStrip = new ContextMenuStrip();
            openMenuItem = new ToolStripMenuItem()
            {
                Text = Strings.Open,
                Visible = true
            };
            exitMenuItem = new ToolStripMenuItem()
            {
                Text = Strings.Exit,
                Visible = true
            };

            openSettingsButton.Text = Strings.Settings;
            exitButton.Text = Strings.Exit;

            contextMenuStrip.Items.AddRange(new ToolStripItem[] {
                openMenuItem,
                exitMenuItem
            });
            SetupSubviews();
        }

        private void SetupSubviews()
        {
            openMenuItem.Click += new EventHandler(OpenMenuItem_Click);
            exitMenuItem.Click += new EventHandler(ExitMenuItem_Click);
            Icon = Images.AppIcon16;
            notifyIcon.Icon = Images.AppIcon16;
            notifyIcon.Visible = false;
            notifyIcon.Text = Strings.TrayIconDefaultText;
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.BalloonTipTitle = Strings.TrayBalloonTitle;
            notifyIcon.BalloonTipText = Strings.TrayBalloonText;
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenForm();
        }

        private void OpenMenuItem_Click(object Sender, EventArgs e)
        {
            OpenForm();
        }

        private void OpenForm()
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            if (notifyIcon.Visible)
            {
                notifyIcon.Visible = false;
            }
            Show();
            Activate();
        }

        private void ExitMenuItem_Click(object Sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_appSettingsService.CurrentSettings.CloseToTray &&
                e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                notifyIcon.Visible = true;
                Hide();
                notifyIcon.ShowBalloonTip(500);
            } else
            {
                e.Cancel = false;
            }
        }

        private void OpenSettingsButton_Click(object sender, EventArgs e)
        {
            _settingsForm.ApplySettings();
            _settingsForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}