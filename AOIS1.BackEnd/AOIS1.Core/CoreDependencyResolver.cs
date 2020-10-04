using AOIS1.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.Core
{
    public static class CoreDependencyResolver
    {
        public static void AddCore(this IServiceCollection services)
        {
            services.AddMapper();
            services.AddServices();
        }
    }
}
