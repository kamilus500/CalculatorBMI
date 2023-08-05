using CalculatorBMI.Domain.Interfaces;
using CalculatorBMI.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorBMI.Infrastructure.Configuration
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICalculateService, CalculateService>();
            services.AddCors(options =>
            {
                options.AddPolicy(name: "Cors",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
        }
    }
}
