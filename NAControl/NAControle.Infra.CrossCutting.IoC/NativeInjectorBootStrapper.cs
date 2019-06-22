using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NAControle.Domain.CommandHandlers;
using NAControle.Domain.Commands.Grupo;
using NAControle.Domain.Handlers;
using NAControle.Domain.Interfaces;
using NAControle.Infra.Data.Contexts;
using NAControle.Infra.Data.Repository;
using NAControle.Infra.Data.UoW;

namespace NAControle.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASPNET
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));



            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Infra - Data
            services.AddScoped<IGrupoRepository, GrupoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EntityContext>();

            // ASPNET
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewGrupoCommand>, GrupoCommandHandler>();


        }
    }
}