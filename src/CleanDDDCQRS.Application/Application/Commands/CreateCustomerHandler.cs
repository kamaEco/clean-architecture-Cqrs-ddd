using CleanDDDCQRS.Domain;
using MediatR;

namespace CleanDDDCQRS.Application
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Guid>
    {
        private readonly ICustomerRepository _repository;

        public CreateCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.FirstName, request.LastName, request.DateOfBirth);
            await _repository.AddAsync(customer);
            return customer.Id;
        }
    }
}
