using Microsoft.EntityFrameworkCore;

namespace EfCoreLazyLoadingNullError;
public class SampleDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LazyLoadingNull;Trusted_Connection=True;")
            .UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Customer>().HasData(
        //    new Customer("John", "Doe") { CustomerId = 1 });

        //modelBuilder.Entity<User>().HasData(
        //    new User("johndoe", "password") { UserId = 1, CustomerId = 1 });
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Customer> Customers => Set<Customer>();
}
