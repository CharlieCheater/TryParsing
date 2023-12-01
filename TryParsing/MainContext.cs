using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParsing
{
    public class MainContext : DbContext
    {
        public MainContext() 
        { 
            Database.EnsureCreated();
        }
        public DbSet<Client> Clients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Parsing2;Username=postgres;Password=postgres;TrustServerCertificate=True");
        }
    }
}
