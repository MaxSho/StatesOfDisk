using StatesOfDisk.Application.Features.UserFeatures.CreateUser;
using StatesOfDisk.Application.Features.UserFeatures.GetAllPCInfo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace StatesOfDisk.WebAPI.Controllers;

[ApiController]
[Route("pcinfo")]
public class PCInfoController : ControllerBase
{
    private readonly IMediator _mediator;

    public PCInfoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllPCInfoResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllPCInfoRequest(), cancellationToken);
        return Ok(response);
    }
    
    [HttpPost]
    public async Task<ActionResult<CreatePCInfoResponse>> Create(CreatePCInfoRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}