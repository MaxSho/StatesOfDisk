using MediatR;

namespace StatesOfDisk.Application.Features.UserFeatures.CreateUser;

public sealed record CreatePCInfoRequest(DateTimeOffset? UpdateTimestamp, string? ComputerNane, decimal? DiskCfreeSpace) : IRequest<CreatePCInfoResponse>;
