using AutoMapper;
using StatesOfDisk.Application.Repositories;
using StatesOfDisk.Domain.Entities;
using MediatR;

namespace StatesOfDisk.Application.Features.UserFeatures.CreateUser;

public sealed class CreatePCInfoHandler : IRequestHandler<CreatePCInfoRequest, CreatePCInfoResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPCInfoRepository _userRepository;
    private readonly IMapper _mapper;

    public CreatePCInfoHandler(IUnitOfWork unitOfWork, IPCInfoRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<CreatePCInfoResponse> Handle(CreatePCInfoRequest request, CancellationToken cancellationToken)
    {
        var pcinfo = _mapper.Map<PCInfo>(request);
        _userRepository.Create(pcinfo);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreatePCInfoResponse>(pcinfo);
    }
}