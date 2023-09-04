using FluentValidation.Results;
using MediatR;
using System.ComponentModel.DataAnnotations;
using ValidationResult = FluentValidation.Results.ValidationResult;

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
