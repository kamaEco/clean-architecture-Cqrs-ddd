using CleanDDDCQRS.Infrastructure;
using MediatR;

namespace CleanDDDCQRS.Application
{
    public class CreateCustomerCommand : IRequest<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
