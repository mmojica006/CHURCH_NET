using CHURCH.Application.Interface;
using CHURCH.Persistence.Context;
using CHURCH.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CHURCH.Persistence.Extensions
{
    public static class InjectionExtensions
    {
        /// <summary>
        /// configuration de la injeccion de dependencia
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {
            //Se configure como ciclo de vida singleton. Se crea una sola instancia de nuestra BD, ciclo de vida singleton
            services.AddSingleton<ApplicationDbContext>();
            services.AddScoped<IDistritoRepository,DistritosRepository>();

           // services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
