using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using CpiDataClient.Core.Mvvm;
using CpiDataClient.Data.Skus;
using DevExpress.Mvvm;
using ODS.Models;
using Prism.Regions;

namespace CpiDataClient.Modules.Skus.ViewModels
{
    public class SkuLoadViewModel(IRegionManager regionManager, ISkusRepository skuRepository)
        : RegionViewModelBase(regionManager), ISupportServices
    {
        private Sku selectedSku;
        private IServiceContainer serviceContainer = null;


        public ObservableCollection<Sku> Skus { get; set; } = new();

        public IServiceContainer ServiceContainer
        {
            get
            {
                if(serviceContainer is null)
                {
                    serviceContainer = new ServiceContainer(this);
                }

                return serviceContainer;
            }
        }

        IServiceContainer ISupportServices.ServiceContainer => ServiceContainer;

        public IMessageBoxService MessageBoxService => ServiceContainer.GetService<IMessageBoxService>();

        public Sku SelectedSku
        {
            get => selectedSku;
            set => SetProperty(ref selectedSku, value);
            
        }

        public override async void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something

            Skus.Clear();
            
            var skus = await skuRepository.GetSkusAsync();
            Skus.AddRange(skus);

            MessageBoxService.Show("Data has been loaded", "Data Load", MessageBoxButton.OK);

        }

        
    }
}
