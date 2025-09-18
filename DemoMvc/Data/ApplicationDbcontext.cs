using Microsoft.EntityFrameworkCore;
using DemoMvc.Models;
using MvcMovie.Models;
using Microsoft.Extensions.Options;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(Options)
        {}
        public DbSet<Person> Persons { get; set; }
    }
}