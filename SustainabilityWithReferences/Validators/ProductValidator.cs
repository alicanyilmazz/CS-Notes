using FluentValidation;
using SustainabilityWithReferences.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Validators
{
    public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().When(x => x.Quantity >1).WithMessage("Name field not be empty!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Surname field not be empty!");
            RuleFor(x => x.Barcode).NotEmpty().WithMessage("IdentityNumber field not be empty!");
            RuleFor(x => x.Barcode).Must(BeUniq);
        }

        private bool BeUniq(string arg)
        {
            return true;
        }
    }
}
