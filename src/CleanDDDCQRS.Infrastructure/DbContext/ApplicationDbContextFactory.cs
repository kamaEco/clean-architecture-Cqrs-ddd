using CleanDDDCQRS.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer("Data Source=.\\kama; Initial Catalog=CLEANDDDCQRS; User ID=kama; Password=kama@@1389; TrustServerCertificate=True");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
