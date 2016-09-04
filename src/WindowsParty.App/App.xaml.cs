using System.Windows;

namespace WindowsParty.App
{
    public partial class App : Application
    {
        private BootStrapper _bootstrapper;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _bootstrapper = new BootStrapper();
            _bootstrapper.Run();
        }
    }
}