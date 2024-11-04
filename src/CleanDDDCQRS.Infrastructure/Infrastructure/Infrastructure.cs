using CleanDDDCQRS.Domain;

namespace CleanDDDCQRS.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetByIdAsync(Guid customerId)
        {
            return await _context.Customers.FindAsync(customerId);
        }
    }
}
