using System.Windows;

namespace CpiDataClient.Modules.Skus.Behaviors;

public interface IMessageBoxService
{
    MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button);
}