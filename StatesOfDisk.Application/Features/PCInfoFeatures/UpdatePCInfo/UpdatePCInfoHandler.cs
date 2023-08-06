using AutoMapper;
using StatesOfDisk.Application.Repositories;
using StatesOfDisk.Domain.Entities;
using MediatR;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.UpdatePCInfo;

public sealed class UpdatePCInfoHandler : IRequestHandler<UpdatePCInfoRequest, UpdatePCInfoResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPCInfoRepository _PCInfoRepository;
    private readonly IMapper _mapper;

    public UpdatePCInfoHandler(IUnitOfWork unitOfWork, IPCInfoRepository userRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _PCInfoRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<UpdatePCInfoResponse> Handle(UpdatePCInfoRequest request, CancellationToken cancellationToken)
    {
        var pcinfo = _mapper.Map<PCInfo>(request);
        _PCInfoRepository.Update(pcinfo);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<UpdatePCInfoResponse>(pcinfo);
    }
}