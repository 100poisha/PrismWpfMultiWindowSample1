using System;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using Prism.Regions;
using System.Linq;
using PrismUnityApp1.Views;

namespace PrismUnityApp1
{
    public class AppModule : IModule
    {
        private IUnityContainer Container { get; }

        public AppModule(IUnityContainer container, IRegionManager regionManager)
        {
            Container = container;
        }

        public void Initialize()
        {
            this.Container.RegisterTypes(
                AllClasses.FromLoadedAssemblies()
                    .Where(x => x.Namespace == "PrismUnityApp1.Views")
                    .Where(x => x.Name != "MainWindow")
                    .Where(x => x.Name != "SubWindow"),
                _ => new[] { typeof(object) },
                WithName.TypeName,
                WithLifetime.PerResolve);
        }
    }
}