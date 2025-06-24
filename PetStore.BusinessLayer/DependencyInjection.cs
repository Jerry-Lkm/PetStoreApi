using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PetStore.DataLayer;

namespace PetStore.BusinessLayer;

public static class DependencyInjection
{
    public static void AddApplicationServices(this IHostApplicationBuilder builder)
    {
        builder.Services.AddDbContext<PetStoreDbContext>((sp, options) =>
        {
            options.UseSqlServer("ConnectionStringName=PetStoreDb");
        });
    }
}