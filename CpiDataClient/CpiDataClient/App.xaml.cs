using CpiDataClient.Modules.ModuleName;
using CpiDataClient.Services;
using CpiDataClient.Services.Interfaces;
using CpiDataClient.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using CpiDataClient.Data.Repositories;
using CpiDataClient.Data.Skus;
using CpiDataClient.Modules.Skus;
using DevExpress.Xpf.Core;

namespace CpiDataClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ApplicationThemeHelper.ApplicationThemeName = Theme.MetropolisDarkName;
        }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
            containerRegistry.RegisterSingleton<ISkusRepository, SkusRepository>();
            
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<SkuModule>();
        }
    }
}
