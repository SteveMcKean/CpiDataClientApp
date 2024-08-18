using CpiDataClient.Data.InboundVariants;
using Microsoft.EntityFrameworkCore;
using ODS.Data;
using ODS.Models;

namespace CpiDataClient.Data.Repositories;

public class InboundDimensionalVariantRepository(OdsContext context, OdsContext dbContext)
    : Repository<InboundDimensionalVariant>(context, dbContext), IInboundVariantsRepository
{
    public Task<List<InboundDimensionalVariant>> GetVariants(Guid skuId)
    {
        return DbContext.InboundDimensionalVariants.Where(i => i.SkuId == skuId).ToListAsync();
        
    }
}