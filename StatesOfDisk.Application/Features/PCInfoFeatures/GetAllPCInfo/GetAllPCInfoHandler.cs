using AutoMapper;
using StatesOfDisk.Application.Repositories;
using MediatR;

namespace StatesOfDisk.Application.Features.UserFeatures.GetAllPCInfo;

public sealed class GetAllPCInfoHandler : IRequestHandler<GetAllPCInfoRequest, List<GetAllPCInfoResponse>>
{
    private readonly IPCInfoRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllPCInfoHandler(IPCInfoRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<List<GetAllPCInfoResponse>> Handle(GetAllPCInfoRequest request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllPCInfoResponse>>(users);
    }
}