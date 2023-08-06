using AutoMapper;
using StatesOfDisk.Application.Repositories;
using MediatR;
using StatesOfDisk.Domain.Entities;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.GetByIdPCInfo;

public sealed class GetPCInfoByIdHandler : IRequestHandler<GetPCInfoByIdRequest, PCInfo>
{
    private readonly IPCInfoRepository _PCInfoRepository;
    private readonly IMapper _mapper;

    public GetPCInfoByIdHandler(IPCInfoRepository userRepository, IMapper mapper)
    {
        _PCInfoRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<PCInfo> Handle(GetPCInfoByIdRequest request, CancellationToken cancellationToken)
    {
        var pc = await _PCInfoRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<PCInfo>(pc);
    }
}