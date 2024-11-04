namespace CleanDDDCQRS.Domain
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
        Task<Customer> GetByIdAsync(Guid customerId);
        // شما می‌توانید متدهای دیگری برای حذف، بروزرسانی و جستجوی مشتری‌ها اضافه کنید.
    }
}
