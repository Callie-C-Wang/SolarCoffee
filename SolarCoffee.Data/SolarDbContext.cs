using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Data
{
    public class SolarDbContext : IdentityDbContext {
        public SolarDbContext() { } // default constructor

        public SolarDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Customer> Customers {get; set; } // developer needs to create C# class with name Customer
        public virtual DbSet<CustomerAddress>
    }
}
