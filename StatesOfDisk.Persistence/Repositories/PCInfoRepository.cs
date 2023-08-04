using StatesOfDisk.Application.Repositories;
using StatesOfDisk.Domain.Entities;
using StatesOfDisk.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace StatesOfDisk.Persistence.Repositories;

public class PCInfoRepository : BaseRepository<PCInfo>, IPCInfoRepository
{
    public PCInfoRepository(DataContext context) : base(context)
    {
    }
    
    public Task<PCInfo> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return Context.PCInfo.FirstOrDefaultAsync(x => x.ComputerNane == email, cancellationToken);
    }
}