using System.Windows;

namespace CpiDataClient.Modules.Skus.Behaviors;

public class MessageBoxService : IMessageBoxService
{
    public MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
    {
        return MessageBox.Show(messageBoxText, caption, button);
    }
}