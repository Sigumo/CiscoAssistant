namespace CiscoClientHelper.Models
{
    public struct AppSettings: IEquatable<AppSettings>
    {
        public string HostName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public bool CloseToTray { get; set; } = true;
        public string CiscoPath { get; set; } = string.Empty;

        public bool Equals(AppSettings other) => 
            HostName == other.HostName && 
            UserName == other.UserName && 
            CloseToTray == other.CloseToTray && 
            CiscoPath == other.CiscoPath;
    }
}
