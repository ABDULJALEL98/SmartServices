using Microsoft.EntityFrameworkCore;
using SmartServices.Models;
using System.Reflection;

namespace SmartServices.Data
{
    public class AppDbContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Services { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
