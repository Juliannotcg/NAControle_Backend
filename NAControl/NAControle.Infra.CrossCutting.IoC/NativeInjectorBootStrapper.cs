using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra - Data
            services.AddScoped<IRepository, Repository>();

        }
    }
}
