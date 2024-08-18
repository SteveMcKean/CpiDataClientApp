using CpiDataClient.Core.Mvvm;
using CpiDataClient.Modules.Skus.Behaviors;
using Prism.Commands;

namespace CpiDataClient.Modules.Skus.ViewModels;

public class UserNotificationViewModel: ViewModelBase
{
    private bool isActive;
    private string message;

    public DelegateCommand ApplyCommand { get; set; }
    public DelegateCommand CancelCommand { get; set; }

    public bool IsActive
    {
        get => isActive;
        set => SetProperty(ref isActive, value);
    }

    public string Message
    {
        get => message;
        set => SetProperty(ref message, value);
    }

    public UserNotificationViewModel()
    {
        ApplyCommand = new DelegateCommand(OnApply, () => true);
        CancelCommand = new DelegateCommand(OnCancel, () => true);
    }

    private void OnCancel()
    {
        IsActive = false;
        var dialogService = GetService<ICurrentDialogService>("CurrentDialogService");

        dialogService.CloseDialog(false, false);
    }

    private void OnApply()
    {
        IsActive = true;

        var dialogService = GetService<ICurrentDialogService>("CurrentDialogService");
        dialogService.CloseDialog(true);

    }
}
