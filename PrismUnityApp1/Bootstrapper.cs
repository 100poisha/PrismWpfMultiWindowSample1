using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using PrismUnityApp1.Views;
using System.Windows;

namespace PrismUnityApp1
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            var regionManager = Container.Resolve<IRegionManager>();
            return new MainWindow(regionManager);
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            var catalog = ModuleCatalog as ModuleCatalog;
            catalog.AddModule(typeof(AppModule));
        }
    }
}
