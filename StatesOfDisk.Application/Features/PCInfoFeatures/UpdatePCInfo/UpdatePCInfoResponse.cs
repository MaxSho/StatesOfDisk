namespace StatesOfDisk.Application.Features.PCInfoFeatures.UpdatePCInfo;

public sealed record UpdatePCInfoResponse
{
    public string Id { get; set; }
    public DateTimeOffset? UpdateTimestamp { get; set; }
    public string? ComputerName { get; set; }
    public decimal? DiskCfreeSpace { get; set; }
}