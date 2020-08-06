using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Utilities
{
    public static class Utility
    {
        /// <summary>
        /// Verify to object using the validator.
        /// </summary>
        /// <param name="validator">Validator implemented from IValidator.</param>
        /// <param name="entity">Entity to be verified</param>
        public static void Validate(IValidator validator, object entity)// First Parameter is : CustomerValidator Second Parameter is : Entity(Customer)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
