using StatesOfDisk.Domain.Common;

namespace StatesOfDisk.Domain.Entities;

public sealed class PCInfo : BaseEntity
{
    public DateTimeOffset? UpdateTimestamp { get; set; }
    public string? ComputerNane { get; set; }
    public decimal? DiskCfreeSpace { get; set; }
}