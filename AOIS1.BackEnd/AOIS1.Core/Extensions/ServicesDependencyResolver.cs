using AOIS1.Core.Services;
using AOIS1.Core.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.Core.Extensions
{
    public static class ServicesDependencyResolver
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IArtistRecommendationService, ArtistRecommendationService>();
            services.AddScoped<IRepositoryService, RepositoryService>();
        }
    }
}
