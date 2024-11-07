using CleanDDDCQRS.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanDDDCQRS.Application.Application.Queries
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, List<Customer>>
    {
        private readonly ICustomerRepository _repository;

        public GetCustomersQueryHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }

}
