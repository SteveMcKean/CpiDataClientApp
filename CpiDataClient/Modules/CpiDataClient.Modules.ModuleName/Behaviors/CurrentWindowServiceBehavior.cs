using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors;

namespace CpiDataClient.Modules.Skus.Behaviors;

public class CurrentWindowServiceBehavior: Behavior<Window>
{
    public static readonly DependencyProperty ClosingCommandProperty =
        DependencyProperty.Register(nameof(ClosingCommand), typeof(ICommand), typeof(CurrentWindowServiceBehavior), new PropertyMetadata(null));

    public ICommand ClosingCommand
    {
        get { return (ICommand)GetValue(ClosingCommandProperty); }
        set { SetValue(ClosingCommandProperty, value); }
    }

    protected override void OnAttached()
    {
        base.OnAttached();
        AssociatedObject.Closing += OnWindowClosing;
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();
        AssociatedObject.Closing -= OnWindowClosing;
    }

    private void OnWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (ClosingCommand != null && ClosingCommand.CanExecute(null))
        {
            ClosingCommand.Execute(null);
        }
    }
}