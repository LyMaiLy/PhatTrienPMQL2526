using Microsoft.EntityFrameworkCore;
using DemoMvc.Models;
using MvcMovie.Models;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}