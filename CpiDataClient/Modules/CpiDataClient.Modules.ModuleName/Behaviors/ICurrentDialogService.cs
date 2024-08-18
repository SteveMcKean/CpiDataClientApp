namespace CpiDataClient.Modules.Skus.Behaviors;

public interface ICurrentDialogService
{
    void CloseDialog<T>(T result, bool? dialogResult = null);
}