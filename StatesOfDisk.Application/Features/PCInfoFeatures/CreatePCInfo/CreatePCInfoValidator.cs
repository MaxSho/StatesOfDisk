using FluentValidation;

namespace StatesOfDisk.Application.Features.UserFeatures.CreateUser;

public sealed class CreatePCInfoValidator : AbstractValidator<CreatePCInfoRequest>
{
    public CreatePCInfoValidator()
    {
        RuleFor(x => x.ComputerNane).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}