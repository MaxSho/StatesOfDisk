using AutoMapper;
using StatesOfDisk.Domain.Entities;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.UpdatePCInfo;

public sealed class UpdatePCInfoMapper : Profile
{
    public UpdatePCInfoMapper()
    {
        CreateMap<UpdatePCInfoRequest, PCInfo>();
        CreateMap<PCInfo, UpdatePCInfoResponse>();
    }
}