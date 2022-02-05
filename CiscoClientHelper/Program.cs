using System.Threading;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;

namespace CiscoClientHelper
{
    internal static class Program
    {

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<MainForm>();
            services.AddSingleton<AppSettingsService>();
            services.AddScoped<SettingsForm>();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);

            using var scope = services.BuildServiceProvider();
            var mainForm = scope.GetRequiredService<MainForm>();
            var appSettingsService = scope.GetRequiredService<AppSettingsService>();
            appSettingsService.InitializeSettings();
            Application.Run(mainForm);
        }
    }
}