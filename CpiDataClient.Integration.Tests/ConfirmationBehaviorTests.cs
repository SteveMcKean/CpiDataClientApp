using NSubstitute;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CpiDataClient.Modules.Skus.Behaviors;
using Microsoft.Xaml.Behaviors;

namespace CpiDataClient.Integration.Tests;

public class ConfirmationBehaviorTests
{
    private readonly SynchronizationContext context = new();
    
    [Fact]
    public void OnButtonClick_ShouldExecuteCommand_WhenUserConfirms()
    {
        // Arrange
        context.Post(state =>
            {
                var messageBoxService = Substitute.For<IMessageBoxService>();

                messageBoxService.Show(Arg.Any<string>(), Arg.Any<string>(), Arg.Any<MessageBoxButton>())
                    .Returns(MessageBoxResult.Yes);

                var command = Substitute.For<ICommand>();
                command.CanExecute(Arg.Any<object>()).Returns(true);

                var button = new Button();
                var behavior = new ConfirmationBehavior(messageBoxService)
                    {
                        Command = command,
                        ConfirmationMessage = "Are you sure?",
                        MessageBoxButton = MessageBoxButton.YesNo
                    };

                Interaction.GetBehaviors(button).Add(behavior);

                // Act
                button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

                // Assert
                command.Received(1).Execute(Arg.Any<object>());
            }, null);
        
    }

    [Fact]
    public void OnButtonClick_ShouldNotExecuteCommand_WhenUserCancels()
    {
        // Arrange
        context.Post(state =>
            {
                var messageBoxService = Substitute.For<IMessageBoxService>();
                messageBoxService.Show(Arg.Any<string>(), Arg.Any<string>(), Arg.Any<MessageBoxButton>())
                    .Returns(MessageBoxResult.No);

                var command = Substitute.For<ICommand>();
                command.CanExecute(Arg.Any<object>()).Returns(true);

                var button = new Button();
                var behavior = new ConfirmationBehavior(messageBoxService)
                    {
                        Command = command,
                        ConfirmationMessage = "Are you sure?",
                        MessageBoxButton = MessageBoxButton.YesNo
                    };

                Interaction.GetBehaviors(button).Add(behavior);

                // Act
                button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

                // Assert
                command.DidNotReceive().Execute(Arg.Any<object>());

            }, null);
        
    }

    [Fact]
    public void OnButtonClick_ShouldNotExecuteCommand_WhenCommandCannotExecute()
    {
        // Arrange
        
        context.Post(state =>
        {
            var messageBoxService = Substitute.For<IMessageBoxService>();
            messageBoxService.Show(Arg.Any<string>(), Arg.Any<string>(), Arg.Any<MessageBoxButton>())
                .Returns(MessageBoxResult.Yes);

            var command = Substitute.For<ICommand>();
            command.CanExecute(Arg.Any<object>()).Returns(false);

            var button = new Button();
            var behavior = new ConfirmationBehavior(messageBoxService)
                {
                    Command = command,
                    ConfirmationMessage = "Are you sure?",
                    MessageBoxButton = MessageBoxButton.YesNo
                };

            Interaction.GetBehaviors(button).Add(behavior);

            // Act
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            // Assert
            command.DidNotReceive().Execute(Arg.Any<object>());

        }, null);
        
       
    }
}
