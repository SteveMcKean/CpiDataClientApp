using ODS.Models;

namespace CpiDataClient.Data.InboundVariants;

public interface IInboundVariantsRepository
{
    Task<List<InboundDimensionalVariant>> GetVariants(Guid skuId);
}