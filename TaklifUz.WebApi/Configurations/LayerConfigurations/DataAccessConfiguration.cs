using Microsoft.EntityFrameworkCore;
using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces;
using TaklifUz.DataAccess.Repositories;

namespace TaklifUz.WebApi.Configurations.LayerConfigurations;

public static class DataAccessConfiguration
{
    public static void ConfigureDataAccess(this WebApplicationBuilder builder)
    {
        string connectionString = builder.Configuration.GetConnectionString("DatabaseConnectionString")!;

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString));

        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}