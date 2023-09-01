using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarniaSystem.ProjetoFila.Core.CQRS.Abstractions.Commands
{
    public abstract class CommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, RequestResponse<TResponse>> where TCommand : Command<TResponse>
    {
        public ValidationResult ValidationResult { get; private set; }

        protected CommandHandler()
        {
            ValidationResult = new ValidationResult();
        }

        public abstract Task<RequestResponse<TResponse>> Handle(TCommand request, CancellationToken cancellationToken);

        public void AddError(params string[] errors)
        {
            foreach (var error in errors)
                ValidationResult.Errors.Add(new ValidationFailure() { ErrorMessage = error });
        }
    }
}
