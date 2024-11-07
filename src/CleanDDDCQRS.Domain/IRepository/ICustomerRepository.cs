namespace CleanDDDCQRS.Domain
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer); 
        Task<Customer> GetByIdAsync(Guid customerId);
        Task<List<Customer>> GetAllAsync();
        Task DeleteAsync(Customer customer);
    }
}
