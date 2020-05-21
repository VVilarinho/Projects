using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace BGT.BGG.Extractor
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddExtractor(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;
        }
    }
}