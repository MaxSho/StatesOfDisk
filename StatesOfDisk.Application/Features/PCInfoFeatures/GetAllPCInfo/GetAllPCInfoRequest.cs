using MediatR;

namespace StatesOfDisk.Application.Features.UserFeatures.GetAllPCInfo;

public sealed record GetAllPCInfoRequest : IRequest<List<GetAllPCInfoResponse>>;