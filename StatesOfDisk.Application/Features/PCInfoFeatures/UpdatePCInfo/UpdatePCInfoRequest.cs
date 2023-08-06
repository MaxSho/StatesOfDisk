using MediatR;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.UpdatePCInfo;

public sealed record UpdatePCInfoRequest(string Id, DateTimeOffset? UpdateTimestamp, string? ComputerName, decimal? DiskCfreeSpace) : IRequest<UpdatePCInfoResponse>;
