using MediatR;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.CreatePCInfo;

public sealed record CreatePCInfoRequest(string Id, DateTimeOffset? UpdateTimestamp, string? ComputerName, decimal? DiskCfreeSpace) : IRequest<CreatePCInfoResponse>;
