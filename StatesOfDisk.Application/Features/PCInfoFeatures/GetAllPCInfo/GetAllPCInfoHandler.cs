using AutoMapper;
using StatesOfDisk.Application.Repositories;
using MediatR;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.GetAllPCInfo;

public sealed class GetAllPCInfoHandler : IRequestHandler<GetAllPCInfoRequest, List<GetAllPCInfoResponse>>
{
    private readonly IPCInfoRepository _PCInfoRepository;
    private readonly IMapper _mapper;

    public GetAllPCInfoHandler(IPCInfoRepository userRepository, IMapper mapper)
    {
        _PCInfoRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<List<GetAllPCInfoResponse>> Handle(GetAllPCInfoRequest request, CancellationToken cancellationToken)
    {
        var pclist = await _PCInfoRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllPCInfoResponse>>(pclist);
    }
}