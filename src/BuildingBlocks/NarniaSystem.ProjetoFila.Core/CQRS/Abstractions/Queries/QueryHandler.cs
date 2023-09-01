using FluentValidation.Results;
using MediatR;

namespace NarniaSystem.ProjetoFila.Core.CQRS.Abstractions.Queries
{
    public abstract class QueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, RequestResponse<TResponse>> where TQuery : Query<TResponse>
    {
        public ValidationResult ValidationResult { get; private set; }

        protected QueryHandler()
        {
            ValidationResult = new ValidationResult();
        }
        
        public abstract Task<RequestResponse<TResponse>> Handle(TQuery request, CancellationToken cancellationToken);

        public void AddError(params string[] errors)
        {
            foreach (var error in errors)
                ValidationResult.Errors.Add(new ValidationFailure() { ErrorMessage = error });
        }
    }
}
