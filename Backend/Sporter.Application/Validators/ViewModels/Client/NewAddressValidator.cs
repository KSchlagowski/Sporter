using FluentValidation;
using Sporter.Application.ViewModels.Client;

namespace Sporter.Application.Validators.ViewModels.Client
{
    public class NewAddressValidator : AbstractValidator<NewAddressVm>
    {
        public NewAddressValidator()
        {
            // RuleFor(x => x.Id).NotNull();
            // RuleFor(x => x.Street).NotEmpty().MinimumLength(3).MaximumLength(50);
            // RuleFor(x => x.BuildingNumber).NotEmpty().MinimumLength(1).MaximumLength(10);
            // RuleFor(x => x.FlatNumber).NotEmpty().MinimumLength(1).MaximumLength(10);
            // RuleFor(x => x.ZipCode).NotEmpty().MinimumLength(3).MaximumLength(10);
            // RuleFor(x => x.City).NotEmpty().MinimumLength(3).MaximumLength(50);
            // RuleFor(x => x.Country).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}