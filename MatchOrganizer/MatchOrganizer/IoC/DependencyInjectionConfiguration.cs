using Autofac;
using Autofac.Extensions.DependencyInjection;
using Database;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchOrganizer.IoC
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceProvider Configure(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterType<MatchOrganizerContext>();     
            var conteiner = builder.Build();
            return conteiner.Resolve<IServiceProvider>();
        }
    }
}
