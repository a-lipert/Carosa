using Carosa.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carosa.Core.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog=CarosaDB");

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<VehicleBrand> VehicleBrand { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleUnit> VehicleUnits { get; set; }    




    }

    
}
