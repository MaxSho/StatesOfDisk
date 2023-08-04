using StatesOfDisk.Application.Repositories;
using StatesOfDisk.Persistence.Context;

namespace StatesOfDisk.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContext _context;

    public UnitOfWork(DataContext context)
    {
        _context = context;
    }
    public Task Save(CancellationToken cancellationToken)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}