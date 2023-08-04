using StatesOfDisk.Domain.Entities;

namespace StatesOfDisk.Application.Repositories;

public interface IPCInfoRepository : IBaseRepository<PCInfo>
{
    Task<PCInfo> GetByEmail(string email, CancellationToken cancellationToken);
}