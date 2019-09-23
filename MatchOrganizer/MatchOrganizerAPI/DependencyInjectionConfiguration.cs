using Autofac;
using Autofac.Extensions.DependencyInjection;
using Database;
using Microsoft.Extensions.DependencyInjection;
using Services.ErrorHandling;
using Services.Helpers;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizerAPI
{
    public class DependencyInjectionConfiguration
    {
        public static IServiceProvider Configure(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterType<MatchOrganizerContext>().InstancePerLifetimeScope();

            builder.RegisterType<MatchService>().As<IMatchService>().InstancePerLifetimeScope();
            builder.RegisterType<TeamService>().As<ITeamService>().InstancePerLifetimeScope();
            builder.RegisterType<PlayerService>().As<IPlayerService>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ServiceExecutor<,>)).As(typeof(IServiceExecutor<,>)).InstancePerLifetimeScope();
            builder.RegisterType<ErrorHandler>().As<IErrorHandler>().InstancePerLifetimeScope();
            builder.RegisterType<MatchTeamPlayerService>().As<IMatchTeamPlayerService>().InstancePerLifetimeScope();

            var conteiner = builder.Build();
            return conteiner.Resolve<IServiceProvider>();
        }
    }
}
