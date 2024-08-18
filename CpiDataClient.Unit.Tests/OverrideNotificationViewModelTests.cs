using CpiDataClient.Modules.Skus.Behaviors;
using CpiDataClient.Modules.Skus.ViewModels;
using NSubstitute;

namespace CpiDataClient.Unit.Tests;

public class OverrideNotificationViewModelTests
{
    private readonly OverrideNotificationViewModel viewModel;
    private readonly ICurrentDialogService currentDialogService;

    public OverrideNotificationViewModelTests()
    {
        // Arrange
        viewModel = new OverrideNotificationViewModel();
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
        currentDialogService.Received(1).CloseDialog(false);
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