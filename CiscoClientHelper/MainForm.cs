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
            notifyIcon.Visible = true;
            notifyIcon.Text = Strings.TrayIconDefaultText;
            notifyIcon.ContextMenuStrip = contextMenuStrip;
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }

        private void OpenMenuItem_Click(object Sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
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
                Hide();
            } else
            {
                e.Cancel = false;
            }
        }

        private void openSettingsButton_Click(object sender, EventArgs e)
        {
            _settingsForm.ApplySettings();
            _settingsForm.Show();
        }
    }
}