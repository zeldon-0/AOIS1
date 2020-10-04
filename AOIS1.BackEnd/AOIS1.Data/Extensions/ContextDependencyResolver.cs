using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AOIS1.Data.Context;

namespace AOIS1.Data.Extensions
{
    public static class ContextDependencyResolver
    {
        public static void AddContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ExpertSystemContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ExpertSystemContext"),
                b => b.MigrationsAssembly("AOIS1.Data"));
                options.EnableDetailedErrors();
            });



        }
    }
}
