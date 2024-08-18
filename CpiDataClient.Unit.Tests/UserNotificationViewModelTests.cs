using CpiDataClient.Modules.Skus.Behaviors;
using CpiDataClient.Modules.Skus.ViewModels;
using Moq;
using NSubstitute;

namespace CpiDataClient.Unit.Tests;

public class UserNotificationViewModelTests
{
    private readonly UserNotificationViewModel viewModel;
    private readonly ICurrentDialogService currentDialogService;

    public UserNotificationViewModelTests()
    {
        // Arrange
        viewModel = new UserNotificationViewModel();
        currentDialogService = Substitute.For<ICurrentDialogService>();

        // Inject the mock dialog service into the ViewModel
        viewModel.RegisterService<ICurrentDialogService>("CurrentDialogService", currentDialogService);
    }

    [Fact]
    public void OnCancel_ShouldSetIsActiveToFalse_And_CloseDialogWithFalse()
    {
        // Act
        viewModel.CancelCommand.Execute();

        // Assert
        Assert.False(viewModel.IsActive);
        currentDialogService.Received(1).CloseDialog(false, false);
    }

    [Fact]
    public void OnApply_ShouldSetIsActiveToTrue_And_CloseDialogWithTrue()
    {
        // Act
        viewModel.ApplyCommand.Execute();

        // Assert
        Assert.True(viewModel.IsActive);
        currentDialogService.Received(1).CloseDialog(true);
    }
}