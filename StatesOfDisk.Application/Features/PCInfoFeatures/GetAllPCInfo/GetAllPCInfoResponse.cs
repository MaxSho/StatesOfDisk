namespace StatesOfDisk.Application.Features.PCInfoFeatures.GetAllPCInfo;

public sealed record GetAllPCInfoResponse
{
    public string Id { get; set; }
    public DateTimeOffset? UpdateTimestamp { get; set; }
    public string? ComputerName { get; set; }
    public decimal? DiskCfreeSpace { get; set; }
}