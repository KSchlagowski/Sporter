using FluentValidation;
using Sporter.Application.ViewModels.Client;

namespace Sporter.Application.Validators.Client.ViewModels
{
    public class NewClientValidator : AbstractValidator<NewClientVm>
    {
        public NewClientValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(255);
            RuleFor(x => x.PhoneNumber).NotEmpty().MinimumLength(7).MaximumLength(15).Matches(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$");
        }
    }
}