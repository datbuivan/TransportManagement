using System.Text.Json;
using TransportManagement.Data.Entities;

namespace TransportManagement.Infrastructure
{
    public class TransportManagementContextSeed
    {
        public static async Task SeedAsync(TransportContext context)
        {
            if (!context.CustomerGroups.Any())
            {
                var customerGroupData = File.ReadAllText("./Infrastructure/SeedData/CustomerGroup.json");
                var customerGroup = JsonSerializer.Deserialize<List<CustomerGroup>>(customerGroupData);
                context.CustomerGroups.AddRange(customerGroup);
            }
            if (!context.UnitManagements.Any())
            {
                var unitManagementsData = File.ReadAllText("./Infrastructure/SeedData/UnitManagement.json");
                var unitManagements = JsonSerializer.Deserialize<List<UnitManagement>>(unitManagementsData);
                context.UnitManagements.AddRange(unitManagements);
            }
            if (!context.DriverUser.Any())
            {
                var driverUserData = File.ReadAllText("./Infrastructure/SeedData/DriverUser.json");
                var driverUsers = JsonSerializer.Deserialize<List<DriverUser>>(driverUserData);
                context.DriverUser.AddRange(driverUsers);
            }
            //if (!context.Customers.Any())
            //{
            //    var customerData = File.ReadAllText("./Infrastructure/SeedData/DriverUser.json");
            //    var customers = JsonSerializer.Deserialize<List<Customer>>(customerData);
            //    context.Customers.AddRange(customers);
            //}
            //if (!context.Trucks.Any())
            //{
            //    var truckData = File.ReadAllText("./Infrastructure/SeedData/Truck.json");
            //    var trucks = JsonSerializer.Deserialize<List<Truck>>(truckData);
            //    context.Trucks.AddRange(trucks);
            //}

            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}
