using Microsoft.EntityFrameworkCore;
using ShoppingApp.Services.CustomerManagement.Models;

namespace ShoppingApp.Services.CustomerManagement.DAL
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
    }
}
