using CpiDataClient.Data.Skus;
using Microsoft.EntityFrameworkCore;
using ODS.Data;
using ODS.Models;

namespace CpiDataClient.Data.Repositories;

public sealed class SkusRepository(OdsContext context, OdsContext dbContext)
    : Repository<Sku>(context, dbContext), ISkusRepository
{
    public Task<Sku?> GetSkuAsync(string skuId)
    {
        return DbContext.Skus
            .Include(s => s.InboundDimensionalVariants)
            .SingleOrDefaultAsync(s => s.Sku1 == skuId);
        
    }

    public Task<List<Sku>> GetSkusAsync()
    {
        return DbContext.Skus
            .Include(s => s.InboundDimensionalVariants)
            .ToListAsync();
    }
}