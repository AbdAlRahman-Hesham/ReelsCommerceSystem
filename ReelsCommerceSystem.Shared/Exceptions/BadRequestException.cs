using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Shared.Exceptions
{
    public sealed class BadRequestException : Exception
    {
        public List<ValidationError> Errors { get; }

        public BadRequestException(List<ValidationError> errors)
            : base("Validation Failed")
        {
            Errors = errors;
        }
        
    }
}
