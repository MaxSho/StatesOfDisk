using StatesOfDisk.Application.Features.PCInfoFeatures.CreatePCInfo;
using StatesOfDisk.Application.Features.PCInfoFeatures.GetAllPCInfo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StatesOfDisk.Domain.Entities;
using StatesOfDisk.Application.Features.PCInfoFeatures.GetByIdPCInfo;
using StatesOfDisk.Domain.Common;
using StatesOfDisk.Application.Features.PCInfoFeatures.UpdatePCInfo;

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
    public async Task<ActionResult<List<UpdatePCInfoResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllPCInfoRequest(), cancellationToken);
        return Ok(response);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<PCInfo>> GetById(string id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetPCInfoByIdRequest(id), cancellationToken);

        if (response == null)
        {
            return NotFound();
        }

        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<CreatePCInfoResponse>> Create(CreatePCInfoRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<UpdatePCInfoResponse>> Update(UpdatePCInfoRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}