using CleanDDDCQRS.Infrastructure;
using MediatR;

namespace CleanDDDCQRS.Application
{
    public class GetCustomerQuery : IRequest<CustomerDto>
    {
        public Guid CustomerId { get; set; }
    }
}
