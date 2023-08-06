using AutoMapper;
using StatesOfDisk.Domain.Entities;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.GetAllPCInfo;

public sealed class GetAllPCInfoMapper : Profile
{
    public GetAllPCInfoMapper()
    {
        CreateMap<PCInfo, GetAllPCInfoResponse>();
    }
}