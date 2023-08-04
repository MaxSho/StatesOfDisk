namespace StatesOfDisk.Application.Features.UserFeatures.CreateUser;

public sealed record CreatePCInfoResponse
{
    public Guid Id { get; set; }
    public DateTimeOffset? UpdateTimestamp { get; set; }
    public string? ComputerNane { get; set; }
    public decimal? DiskCfreeSpace { get; set; }
}