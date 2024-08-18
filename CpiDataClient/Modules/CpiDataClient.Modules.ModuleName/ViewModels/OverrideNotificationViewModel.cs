using CpiDataClient.Core.Mvvm;
using CpiDataClient.Modules.Skus.Behaviors;
using Prism.Commands;

namespace CpiDataClient.Modules.Skus.ViewModels;

public class OverrideNotificationViewModel: ViewModelBase
{
    private bool isActive;
    private string message;

    public string Message
    {
        get => message;
        set => SetProperty(ref message, value);
    }

    public bool IsActive
    {
        get => isActive;
        set => SetProperty(ref isActive, value);
    }

    public DelegateCommand ApplyCommand { get; set; }
    public DelegateCommand CancelCommand { get; set; }
    
    
    public OverrideNotificationViewModel()
    {
        ApplyCommand = new DelegateCommand(OnApply, () => true);
        CancelCommand = new DelegateCommand(OnCancel, () => true);
        
    }

    private void OnCancel()
    {
        IsActive = false;
        var dialogService = GetService<ICurrentDialogService>("CurrentDialogService");
        
        dialogService.CloseDialog(false);
    }

    private void OnApply()
    {
        IsActive = true;
        
        var dialogService = GetService<ICurrentDialogService>("CurrentDialogService");
        dialogService.CloseDialog(true);

    }
}