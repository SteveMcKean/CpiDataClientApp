using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors;

namespace CpiDataClient.Modules.Skus.Behaviors;

public class MessageBoxBehavior: Behavior<UIElement>
{
    public string Message { get; set; }

    protected override void OnAttached()
    {
        base.OnAttached();
        AssociatedObject.MouseDown += AssociatedObject_MouseDown;
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();
        AssociatedObject.MouseDown -= AssociatedObject_MouseDown;
    }

    private void AssociatedObject_MouseDown(object sender, MouseButtonEventArgs e)
    {
        MessageBox.Show(Message);
    }
}