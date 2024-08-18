using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Xpf.Diagram.Native;
using Microsoft.Xaml.Behaviors;

namespace CpiDataClient.Modules.Skus.Behaviors;

public class ConfirmationBehavior: Behavior<Button>
{
    public static readonly DependencyProperty CommandProperty =
        DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(ConfirmationBehavior), new PropertyMetadata(null));

    public static readonly DependencyProperty ConfirmationMessageProperty =
        DependencyProperty.Register(nameof(ConfirmationMessage), typeof(string), typeof(ConfirmationBehavior), new PropertyMetadata("Are you sure?"));

    public static readonly DependencyProperty MessageBoxButtonProperty =
        DependencyProperty.Register(nameof(MessageBoxButton), typeof(MessageBoxButton), typeof(ConfirmationBehavior), new PropertyMetadata(MessageBoxButton.YesNo));


    public static readonly DependencyProperty CommandParameterProperty =
        DependencyProperty.Register(nameof(CommandParameter), typeof(object), typeof(ConfirmationBehavior), new PropertyMetadata(null));


    public ICommand Command
    {
        get { return (ICommand)GetValue(CommandProperty); }
        set { SetValue(CommandProperty, value); }
    }

    public string ConfirmationMessage
    {
        get { return (string)GetValue(ConfirmationMessageProperty); }
        set { SetValue(ConfirmationMessageProperty, value); }
    }

    public MessageBoxButton MessageBoxButton
    {
        get { return (MessageBoxButton)GetValue(MessageBoxButtonProperty); }
        set { SetValue(MessageBoxButtonProperty, value); }
    }

    public object CommandParameter
    {
        get { return GetValue(CommandParameterProperty); }
        set { SetValue(CommandParameterProperty, value); }
    }

    protected override void OnAttached()
    {
        base.OnAttached();
        AssociatedObject.Click += OnButtonClick;
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();
        AssociatedObject.Click -= OnButtonClick;
    }

    private void OnButtonClick(object sender, RoutedEventArgs e)
    {
        var result = MessageBox.Show(ConfirmationMessage, "Confirmation", MessageBoxButton);

        if ((result == MessageBoxResult.Yes || result == MessageBoxResult.OK) && Command?.CanExecute(CommandParameter) == true)
        {
            Command.Execute(CommandParameter);
        }
    }
}