using MediatR;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.GetAllPCInfo;

public sealed record GetAllPCInfoRequest : IRequest<List<GetAllPCInfoResponse>>;