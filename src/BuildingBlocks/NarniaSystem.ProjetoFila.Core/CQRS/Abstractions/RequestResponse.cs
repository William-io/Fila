using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarniaSystem.ProjetoFila.Core.CQRS.Abstractions
{
    public class RequestResponse<TResponse>
    {
        public TResponse Response { get; private set; }
        public bool Success { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public RequestResponse(bool success, ValidationResult validationResult, TResponse response = default)
        {
            Success = success;
            ValidationResult = validationResult;
            Response = response;
        }
    }
}
