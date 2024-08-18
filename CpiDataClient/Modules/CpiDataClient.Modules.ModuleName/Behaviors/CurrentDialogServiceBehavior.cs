using System;
using System.Windows;
using System.Windows.Controls;
using CpiDataClient.Core.Mvvm;
using Microsoft.Xaml.Behaviors;

namespace CpiDataClient.Modules.Skus.Behaviors;

public class CurrentDialogServiceBehavior : Behavior<UserControl>, ICurrentDialogService
{
    public event Action<object> DialogClosed;
    
    protected override void OnAttached()
    {
        base.OnAttached();

        if (AssociatedObject != null && AssociatedObject.DataContext is ViewModelBase viewModel)
        {
            // Register this behavior as a service so it can close the window
            viewModel.RegisterService<ICurrentDialogService>("CurrentDialogService", this);
        }
    }

    public void CloseDialog<T>(T result, bool? dialogResult = null)
    {
        // Find the parent window that contains the UserControl
        var window = Window.GetWindow(AssociatedObject);
        if (window != null)
        {
            window.DialogResult = dialogResult;
            window.Close();
        }

        // Raise the DialogClosed event to return the result
        DialogClosed?.Invoke(result);
    }
}