using AutoMapper;
using StatesOfDisk.Domain.Entities;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.CreatePCInfo;

public sealed class CreatePCInfoMapper : Profile
{
    public CreatePCInfoMapper()
    {
        CreateMap<CreatePCInfoRequest, PCInfo>();
        CreateMap<PCInfo, CreatePCInfoResponse>();
    }
}