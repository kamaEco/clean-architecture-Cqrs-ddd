﻿using CleanDDDCQRS.Domain;
using CleanDDDCQRS.Infrastructure;
using MediatR;

namespace CleanDDDCQRS.Application
{
    public class GetCustomerQuery : IRequest<CustomerDto>
    {
        public Guid CustomerId { get; set; }
    }

    public class GetCustomerHandler : IRequestHandler<GetCustomerQuery, CustomerDto>
    {
        private readonly ICustomerRepository _repository;

        public GetCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<CustomerDto> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetByIdAsync(request.CustomerId);
            return new CustomerDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                DateOfBirth = customer.DateOfBirth
            };
        }
    }
}