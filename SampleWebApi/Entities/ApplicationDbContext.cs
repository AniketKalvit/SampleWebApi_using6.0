using Microsoft.EntityFrameworkCore;
using SampleWebApi.Models;

namespace SampleWebApi.Entities
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
