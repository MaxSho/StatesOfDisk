using FluentValidation;

namespace StatesOfDisk.Application.Features.PCInfoFeatures.CreatePCInfo;

public sealed class CreatePCInfoValidator : AbstractValidator<CreatePCInfoRequest>
{
    public CreatePCInfoValidator()
    {
        RuleFor(x => x.ComputerName).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}