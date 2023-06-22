using GameDistribution.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameDistribution.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Titles> Titles { get; set; }
        public DbSet<Publisher> Publishers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Joey", LastName = "Emery", Phone = "294827323", Membership = true },
                new Customer { Id = 2, FirstName = "Cooper", LastName = "Emery", Phone = "483795747", Membership = true },
                new Customer { Id = 3, FirstName = "Lhoucine", LastName = "Zerrouki", Phone = "38493847", Membership = false }
                );

            builder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "Joey", LastName = "Emery", EmployeeNumber = "123456789" },
                new Employee { Id = 2, FirstName = "Cooper", LastName = "Emery", EmployeeNumber = "987654321" },
                new Employee { Id = 3, FirstName = "Lhoucine", LastName = "Zerrouki", EmployeeNumber = "456789123" }
                );
            builder.Entity<Titles>().HasData(
                new Titles { Id = 1, Title = "Red Dead Redemption", Genre = "Open World", Year = 10/26/2018 },
                new Titles { Id = 2, Title = "HALO", Genre = "FPS", Year = 10 / 26 / 2018 },
                new Titles { Id = 3, Title = "Call Fo Duty", Genre = "FPS", Year = 10 / 26 / 2018}
                );

            builder.Entity<Publisher>().HasData(
                new Publisher { Id = 1, Name = "RockStar", state = "WA", city = "Bellevue", country = "America" },
                new Publisher { Id = 2, Name = "Bungie", state = "NY", city = "New York", country = "America" },
                new Publisher { Id = 3, Name = "Joey", state = "CA", city = "Santa Monica", country = "America" }
                );
            

            base.OnModelCreating(builder);
        }
    }
}