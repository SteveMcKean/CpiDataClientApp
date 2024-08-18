using CpiDataClient.Core;
using CpiDataClient.Modules.ModuleName.Views;
using CpiDataClient.Modules.Skus.ViewModels;
using CpiDataClient.Modules.Skus.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace CpiDataClient.Modules.Skus
{
    public class SkuModule(IRegionManager regionManager) : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            regionManager.RequestNavigate(RegionNames.ContentRegion, "TestView");
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<SkuLoadViewModel>();
            containerRegistry.RegisterForNavigation<SkuLoadView>();
            containerRegistry.RegisterForNavigation<TestView>();

        }
    }
}