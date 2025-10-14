using FluentValidation;
using FluentValidation.Results;
using MediatR;
using OMPS.ApplicationKatmanı.Messaging;

namespace OMPS.ApplicationKatmanı.Behavior
{
    public sealed class ValidationBehavior<TRequest, TResponse> :
        IPipelineBehavior<TRequest, TResponse>
        where TRequest : class, ICommand<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public Task<TResponse> Handle(TRequest request, 
            RequestHandlerDelegate<TResponse> next, 
            CancellationToken cancellationToken)
        {         
            if(!_validators.Any())
                return next();
            var context = new ValidationContext<TRequest>(request);

            var validationResults = _validators
                .Select(v => v.Validate(context))
                .SelectMany(result => result.Errors)
                .Where(failure => failure != null)
                .GroupBy(e => e.PropertyName,
                    e => e.ErrorMessage, (propertNmae, errorMessage) => new
                    {
                        Key = propertNmae,
                        Values = errorMessage.Distinct().ToArray()
                    })
                .ToDictionary(e => e.Key, e => e.Values[0]);

            if (validationResults.Any())
            {
                var errors = validationResults.Select(s => new ValidationFailure
                {
                    PropertyName = s.Value,
                    ErrorCode = s.Key
                });
                throw new ValidationException(errors);

            }
            return next();
        }
    }
}
