namespace StatesOfDisk.Application.Features.PCInfoFeatures.CreatePCInfo;

public sealed record CreatePCInfoResponse
{
    public string Id { get; set; }
    public DateTimeOffset? UpdateTimestamp { get; set; }
    public string? ComputerName { get; set; }
    public decimal? DiskCfreeSpace { get; set; }
}