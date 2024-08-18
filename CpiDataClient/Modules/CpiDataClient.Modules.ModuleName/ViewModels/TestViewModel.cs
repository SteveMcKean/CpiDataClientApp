using ODS.Models;
using Prism.Regions;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CpiDataClient.Core.Mvvm;
using CpiDataClient.Data.Repositories;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using DevExpress.Mvvm;
using System.Windows;
using DelegateCommand = Prism.Commands.DelegateCommand;
using IDialogService = CpiDataClient.Core.IDialogService;

namespace CpiDataClient.Modules.Skus.ViewModels;

public class TestViewModel : RegionViewModelBase, ISupportServices
{
    private Sku selectedSku;
    private ServiceContainer serviceContainer = null;
    private readonly SkusRepository skuRepository1;
    
    public ObservableCollection<Sku> Skus { get; set; } = new();

    public Prism.Commands.DelegateCommand<object> RefreshCommand { get; set; }
    
    public DelegateCommand LoadedCommand { get; set; }
    public DelegateCommand ShowNotificationCommand { get; set; }

    public DelegateCommand ShowDialogCommand { get; set; }
    
    public IServiceContainer ServiceContainer
    {
        get
        {
            if (serviceContainer is null)
            {
                serviceContainer = new ServiceContainer(this);
            }

            return serviceContainer;
        }
    }

    IServiceContainer ISupportServices.ServiceContainer => ServiceContainer;

    public IMessageBoxService MessageBoxService => ServiceContainer.GetService<IMessageBoxService>();

    public TestViewModel(IRegionManager regionManager, SkusRepository skuRepository) : base(regionManager)
    {
        skuRepository1 = skuRepository;
        
        LoadedCommand = new DelegateCommand(OnLoaded, () => true);
        RefreshCommand = new Prism.Commands.DelegateCommand<object>(OnRefresh, (object obj) => true);
        ShowDialogCommand = new DelegateCommand(OnShowDialog, () => true);
        
        ShowNotificationCommand = new DelegateCommand(OnShowNotification, () => true);
    }

    private void OnShowNotification()
    {
        var dialogService = GetService<IDialogService>("UserNotificationView");
        if (dialogService != null)
        {
            var dialogViewModel = new UserNotificationViewModel { Message = "User notification view" };
            var results = dialogService.ShowDialog(dialogViewModel);

        }
    }

    private void OnShowDialog()
    {
        var dialogService = GetService<IDialogService>("OverrideNotification");
        if (dialogService != null)
        {
            var dialogViewModel = new OverrideNotificationViewModel { Message = "Hello from Dialog!" };
            dialogService.ShowDialog(dialogViewModel);

            if (dialogViewModel.IsActive)
            {
                OnShowNotification();
            }
            
        }
    }

    private void OnRefresh(object obj)
    {
        
    }


    public Sku SelectedSku
    {
        get => selectedSku;
        set => SetProperty(ref selectedSku, value);

    }
    
    public void OnLoaded()
    {
        MessageBoxService.Show("loaded event fired", "Data Load", MessageBoxButton.OK);
    }

    public override async void OnNavigatedTo(NavigationContext navigationContext)
    {
        Skus.Clear();

        var skus = await skuRepository1.GetSkusAsync();
        Skus.AddRange(skus);

        MessageBoxService.Show("Data has been loaded", "Data Load", MessageBoxButton.OK);

    }

    [AsyncCommand]
    public async Task ValidateRowCommand(RowValidationArgs args)
    {
        var item = (InboundDimensionalVariant)args.Item;
        if (args.IsNewItem)
        {
            SelectedSku.InboundDimensionalVariants.Add(item);
            await skuRepository1.SaveChangesAsync();
            
        }
        
    }
    
    [AsyncCommand]
    public async Task ValidateRowDeletionCommand(ValidateRowDeletionArgs args)
    {
        var item = (InboundDimensionalVariant)args.Items.Single();
        SelectedSku.InboundDimensionalVariants.Remove(item);

        await skuRepository1.SaveChangesAsync();
        
    }
    
    [AsyncCommand]
    public async Task DataSourceRefreshCommand(DataSourceRefreshArgs args)
    {
        Skus.Clear();
        
        var skus = await skuRepository1.GetSkusAsync();
        Skus.AddRange(skus);
        
    }
}

