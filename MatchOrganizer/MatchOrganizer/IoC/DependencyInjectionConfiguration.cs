using Autofac;
using Autofac.Extensions.DependencyInjection;
using Database;
using Microsoft.Extensions.DependencyInjection;
using Services.ErrorHandling;
using Services.Helpers;
using Services.Interfaces;
using Services.Services;
using System;

namespace MatchOrganizer.IoC
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceProvider Configure(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterType<MatchOrganizerContext>().InstancePerLifetimeScope();

            builder.RegisterType<StatusService>().As<IStatusService>().InstancePerLifetimeScope();
            builder.RegisterType<MatchService>().As<IMatchService>().InstancePerLifetimeScope();
            builder.RegisterType<TeamService>().As<ITeamService>().InstancePerLifetimeScope();
            builder.RegisterType<PlayerService>().As<IPlayerService>().InstancePerLifetimeScope();
            builder.RegisterType<PlayerStatisticService>().As<IPlayerStatisticsService>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ServiceExecutor<,>)).As(typeof(IServiceExecutor<,>)).InstancePerLifetimeScope();
            builder.RegisterType<ErrorHandler>().As<IErrorHandler>().InstancePerLifetimeScope();


            var conteiner = builder.Build();
            return conteiner.Resolve<IServiceProvider>();
        }
    }
}
