using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CHURCH.Application.UseCase.Extensions
{
    public static class Injection_Extensions
    {
        public static IServiceCollection AddInjectionApplication(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }
    }
}
