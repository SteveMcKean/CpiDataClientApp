using ODS.Data;

namespace CpiDataClient.Data.Repositories;

public abstract class Repository<TEntity> where TEntity : class
{
    protected readonly OdsContext DbContext;

    protected Repository(OdsContext context, OdsContext dbContext)
    {
        this.DbContext = dbContext;
        
    }
    
    public void Add(TEntity entity)
    {
        DbContext.Add(entity);
        
    }

    public void Update(TEntity entity)
    {
        DbContext.Update(entity);

    }

    public void Remove(TEntity entity)
    {
        DbContext.Remove(entity);

    }

    public async Task SaveChangesAsync()
    {
        await DbContext.SaveChangesAsync();
        
    }

}