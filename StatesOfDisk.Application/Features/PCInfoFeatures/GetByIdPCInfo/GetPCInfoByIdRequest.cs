using MediatR;
using StatesOfDisk.Domain.Entities;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.GetByIdPCInfo;

public sealed record GetPCInfoByIdRequest(string Id) : IRequest<PCInfo>;