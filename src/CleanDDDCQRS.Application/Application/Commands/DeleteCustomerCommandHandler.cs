using CleanDDDCQRS.Domain;
using MediatR;

namespace CleanDDDCQRS.Application.Application.Commands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
    {
        private readonly ICustomerRepository _repository;

        public DeleteCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetByIdAsync(request.CustomerId);
            if (customer == null)
                throw new EntityNotFoundException(request.CustomerId);

            await _repository.DeleteAsync(customer);
            return Unit.Value;
        }
    }

}
