using System;
using FluentValidation;
using Sporter.Application.ViewModels.Item;

namespace Sporter.Application.Validators.ViewModels.Item
{
    public class NewItemValidator : AbstractValidator<NewItemVm>
    {
        public NewItemValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Category).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Price).NotNull().GreaterThan(0).LessThan(999999);
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.ExpireDate).NotEmpty().Must(BeAValidDate);
                //.WithMessage("'Expire date' is not in the correct format.")
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}