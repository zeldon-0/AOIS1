using System;
using System.Collections.Generic;
using System.Text;
using AOIS1.Data.Extensions;
using GameStore.Data.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AOIS1.Data
{
    public static class DataDependencyResolver
    {
        public static void AddData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddUOW();
            services.AddContext(configuration);
        }

    }
}
