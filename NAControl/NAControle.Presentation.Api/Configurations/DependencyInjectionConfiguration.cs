using Microsoft.Extensions.DependencyInjection;
using NAControle.Infra.CrossCutting.IoC;

namespace NAControle.Presentation.Api.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
