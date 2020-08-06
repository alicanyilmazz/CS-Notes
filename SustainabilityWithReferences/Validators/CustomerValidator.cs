using FluentValidation;
using SustainabilityWithReferences.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Validators
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().When(x=>x.CustomerIdentity=="123").WithMessage("CustomerName field not be empty!");
            RuleFor(x => x.CustomerCode).NotEmpty().WithMessage("CustomerCode field not be empty!");
            RuleFor(x => x.CustomerIdentity).NotEmpty().WithMessage("Customer Identity field not be empty!");
            RuleFor(x => x.CustomerIdentity).Must(BeEven);
        }

        private bool BeEven(string arg)
        {
            return true;
        }
    }
}
