
using PatientInfoPortal.API.DBMigrationSeedServices;

namespace PatientInfoPortal.API.HostedServices
{
    public class DbMigrationAndSeederHostedService(IServiceProvider serviceProvider) : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = serviceProvider.CreateScope();
            var seeder = scope.ServiceProvider.GetRequiredService<DbMigrationAndSeederService>();
            await seeder.MigrateAsync();
            await seeder.SeedAsync();
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
