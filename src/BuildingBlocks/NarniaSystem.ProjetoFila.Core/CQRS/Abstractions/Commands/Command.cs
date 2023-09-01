using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarniaSystem.ProjetoFila.Core.CQRS.Abstractions.Commands
{
    public abstract class Command<TResponse> : IRequest<RequestResponse<TResponse>>
    {
        public DateTime Timestamp { get; private set; } = DateTime.Now;
        public ValidationResult ValidationResult { get; private set; }

        public Command()
        {
            ValidationResult = new ValidationResult();
        }

        public abstract bool IsValid();
    }
}
