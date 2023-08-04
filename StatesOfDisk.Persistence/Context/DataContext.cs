using StatesOfDisk.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace StatesOfDisk.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<PCInfo>? PCInfo { get; set; }
}