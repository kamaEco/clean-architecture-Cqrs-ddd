using CleanDDDCQRS.Domain;
using MediatR;
using System.Threading;

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
            // بررسی اینکه آیا درخواست لغو شده است یا خیر
            cancellationToken.ThrowIfCancellationRequested();

            var customer = new Customer(request.FirstName, request.LastName, request.DateOfBirth);

            // بررسی مجدد برای اطمینان از لغو نشدن عملیات
            cancellationToken.ThrowIfCancellationRequested();
            
            // افزودن مشتری به دیتابیس
            await _repository.AddAsync(customer);


            return customer.Id;
        }
    }
}
