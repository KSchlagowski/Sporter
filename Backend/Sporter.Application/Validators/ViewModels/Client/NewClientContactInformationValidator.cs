using FluentValidation;
using Sporter.Application.ViewModels.Client;

namespace Sporter.Application.Validators.ViewModels.Client
{
    public class NewClientContactInformationValidator : AbstractValidator<NewClientContactInformationVm>
    {
        public NewClientContactInformationValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(4).MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(4).MaximumLength(50);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
        }
    }
}