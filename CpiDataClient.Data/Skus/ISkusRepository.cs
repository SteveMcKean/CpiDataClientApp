using ODS.Models;

namespace CpiDataClient.Data.Skus;

public interface ISkusRepository
{
    Task<Sku?> GetSkuAsync(string skuId);

    Task<List<Sku>> GetSkusAsync();
}