using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace WindowsParty.App
{
    public class BootStrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }
        protected override void InitializeModules()
        {
            base.InitializeModules();
            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            this.ModuleCatalog.AddModule(null); // placeholder
        }
    }
}