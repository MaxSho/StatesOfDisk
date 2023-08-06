using FluentValidation;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.UpdatePCInfo;

public sealed class UpdatePCInfoValidator : AbstractValidator<UpdatePCInfoRequest>
{
    public UpdatePCInfoValidator()
    {
        RuleFor(x => x.ComputerName).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}