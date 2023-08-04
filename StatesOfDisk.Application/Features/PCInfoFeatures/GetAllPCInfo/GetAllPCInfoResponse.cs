namespace StatesOfDisk.Application.Features.UserFeatures.GetAllPCInfo;

public sealed record GetAllPCInfoResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset? UpdateTimestamp { get; set; }
    public string? ComputerNane { get; set; }
    public decimal? DiskCfreeSpace { get; set; }
}