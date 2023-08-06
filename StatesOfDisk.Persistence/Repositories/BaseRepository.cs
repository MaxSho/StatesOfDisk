using StatesOfDisk.Application.Repositories;
using StatesOfDisk.Domain.Common;
using StatesOfDisk.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace StatesOfDisk.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly DataContext Context;

    public BaseRepository(DataContext context)
    {
        Context = context;
    }
    
    public void Create(T entity)
    {
        entity.DateCreated = DateTime.Now;
        Context.Add(entity);
    }

    public void Update(T entity)
    {
        entity.DateUpdated = DateTime.Now;
        Context.Update(entity);
    }

    public void Delete(T entity)
    {
        entity.DateCreated = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }

    public Task<T> Get(string id, CancellationToken cancellationToken)
    {
        return Context.Set<T>().FirstOrDefaultAsync(x => x.Id  == id, cancellationToken);
    }

    public Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return Context.Set<T>().ToListAsync(cancellationToken);
    }
}