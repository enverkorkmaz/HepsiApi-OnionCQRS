using HepsiApi.Application.Interfaces.Repositories;
using HepsiApi.Persistence.Context;
using HepsiApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HepsiApi.Persistence
{
    public static class Registration
    {
        public static void AddPersistance(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>),typeof(ReadRepository<>));
        }
    }
}
