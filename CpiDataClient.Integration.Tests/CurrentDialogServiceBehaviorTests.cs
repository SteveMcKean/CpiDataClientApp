using System.Windows;
using System.Windows.Controls;
using CpiDataClient.Core.Mvvm;
using CpiDataClient.Modules.Skus.Behaviors;
using Microsoft.Xaml.Behaviors;
using NSubstitute;

namespace CpiDataClient.Integration.Tests;

public class CurrentDialogServiceBehaviorTests
{
    private readonly SynchronizationContext context = new();

    [Fact]
    public void OnAttached_ShouldRegisterCurrentDialogService_WithViewModel()
    {
        // Arrange
        context.Post(state =>
            {
                var userControl = new UserControl();
                var viewModel = Substitute.For<ViewModelBase>();

                userControl.DataContext = viewModel;

                var behavior = new CurrentDialogServiceBehavior();

                // Act
                Interaction.GetBehaviors(userControl).Add(behavior);

                // Assert
                viewModel.Received(1).RegisterService<ICurrentDialogService>("CurrentDialogService", behavior);
            }, null);
        
    }

    [Fact]
    public void CloseDialog_ShouldFindParentWindow_And_CloseIt_WithDialogResult()
    {

        // Arrange
        context.Post(state =>
            {
                var window = new Window();
                var userControl = new UserControl();
                window.Content = userControl;

                var behavior = new CurrentDialogServiceBehavior();
                Interaction.GetBehaviors(userControl).Add(behavior);

                bool dialogClosedEventCalled = false;
                behavior.DialogClosed += result => dialogClosedEventCalled = true;

                // Act
               
                behavior.CloseDialog("TestResult", true);
               
                // Assert
                Assert.True(dialogClosedEventCalled);
                
            }, null);
       
    }

    [Fact]
    public void CloseDialog_ShouldRaiseDialogClosedEvent_WithGivenResult()
    {
        // Arrange
        context.Post(state =>
            {
                var userControl = new UserControl();
                var behavior = new CurrentDialogServiceBehavior();

                Interaction.GetBehaviors(userControl).Add(behavior);

                object receivedResult = null;
                behavior.DialogClosed += result => receivedResult = result;

                // Act
                behavior.CloseDialog("ExpectedResult", true);

                // Assert
                Assert.Equal("ExpectedResult", receivedResult);
                
            }, null);
       
    }
}
