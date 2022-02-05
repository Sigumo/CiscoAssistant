using CiscoClientHelper.Models;

namespace CiscoClientHelper
{
    public partial class SettingsForm : Form
    {
        private readonly AppSettingsService _appSettingsService;
        private AppSettings formSettings;
        public SettingsForm(AppSettingsService appSettingsService)
        {
            InitializeComponent();
            _appSettingsService = appSettingsService;
            Icon = Images.AppIcon16;
            Text = Strings.Settings;
            assistantSettings.Text = Strings.AssistantSettings;
            connectionSettings.Text = Strings.ConnectionSettings;
            saveSettingsButton.Text = Strings.Save;
            cancelButton.Text = Strings.Cancel;
        }

        public void ApplySettings()
        {
            formSettings = _appSettingsService.CurrentSettings;
            closeToTrayBox.Checked = formSettings.CloseToTray;
            hostNameBox.Text = formSettings.HostName;
            anyConnectDirectoryBox.Text = formSettings.CiscoPath;
            userNameBox.Text = formSettings.UserName;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_appSettingsService.CurrentSettings.Equals(formSettings))
            {

            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            _appSettingsService.UpdateSettings(formSettings);
            _appSettingsService.TrySaveSettings();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void HostNameBox_TextChanged(object sender, EventArgs e)
        {
            formSettings.HostName = hostNameBox.Text;
        }

        private void AnyConnectDirectoryBox_TextChanged(object sender, EventArgs e)
        {
            formSettings.CiscoPath = anyConnectDirectoryBox.Text;
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {
            formSettings.UserName = userNameBox.Text;
        }

        private void CloseToTrayBox_CheckedChanged(object sender, EventArgs e)
        {
            formSettings.CloseToTray = closeToTrayBox.Checked;
        }
    }
}
