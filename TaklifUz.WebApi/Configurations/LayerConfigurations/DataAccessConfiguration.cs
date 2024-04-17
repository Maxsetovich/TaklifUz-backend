using Microsoft.EntityFrameworkCore;
using TaklifUz.DataAccess.DbContexts;

namespace TaklifUz.WebApi.Configurations.LayerConfigurations;

public static class DataAccessConfiguration
{
    public static void ConfigureDataAccess(this WebApplicationBuilder builder)
    {
        string connectionString = builder.Configuration.GetConnectionString("DatabaseConnectionString")!;

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
    }
}
