using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TransportManagement.Data.Entities;

namespace TransportManagement.Infrastructure
{
    public class TransportContext : DbContext
    {
        public TransportContext(DbContextOptions<TransportContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.SqlServer")
            {
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType
                    == typeof(decimal));
                    foreach (var property in properties)
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name)
                        .HasConversion<double>();
                    }
                }
            }

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<CustomerGroup> CustomerGroups { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<UnitManagement> UnitManagements { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<DriverUser> DriverUser { get; set; }
        public DbSet<PackageByDistance> PackageByDistances { get; set; }
        public DbSet<PackageByTrip> PackageByTrips { get; set; }
        public DbSet<PackageShift> PackageShifts { get; set; }
        public DbSet<PackageDetail> PackageDetails { get; set; }
        public DbSet<BillingOperateType> BillingOperateTypes { get; set; }
        public DbSet<BillingOperate> BillingOperates { get; set; }
        public DbSet<TruckRoute> TruckRoutes { get; set; }
        public DbSet<RoutePoint> RoutePoints { get; set; }
        public DbSet<TruckTrip> TruckTrips { get; set; }
        public DbSet<TripPoint> TripPoints { get; set; }



    }
}
