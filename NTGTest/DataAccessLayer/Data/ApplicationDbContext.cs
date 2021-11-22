using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NTGTest.DataAccessLayer.Entities;
using System.IO;

namespace NTGTest.DataAccessLayer.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
