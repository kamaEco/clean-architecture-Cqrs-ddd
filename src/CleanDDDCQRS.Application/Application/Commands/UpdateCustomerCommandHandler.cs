using CleanDDDCQRS.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanDDDCQRS.Application.Application.Commands
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository _repository;

        public UpdateCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetByIdAsync(request.CustomerId);
            if (customer == null)
                throw new EntityNotFoundException(request.CustomerId);

            customer.FirstName = request.Name;
            customer.LastName = request.Family;

            await _repository.UpdateAsync(customer);
            return Unit.Value;
        }
    }

}
