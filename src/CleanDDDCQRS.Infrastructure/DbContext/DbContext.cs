using Microsoft.EntityFrameworkCore;
using CleanDDDCQRS.Domain;

namespace CleanDDDCQRS.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } // اینجا DbSet را تعریف کنید

        // در صورت نیاز DbSet های دیگری نیز برای سایر موجودیت‌ها اضافه کنید.
    }
}
