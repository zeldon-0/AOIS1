using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using AOIS1.Core.Repositories.Contracts;
using AOIS1.Data.Repositories;
using AOIS1.Core.Domain.Models.Characteristics;

namespace GameStore.Data.Extensions
{
    public static class RepositoryDependencyResolver
    {
        public static void AddUOW(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IGenericRepository<Genre>, GenericRepository<Genre>>();
            services.AddScoped<IGenericRepository<Instrument>, GenericRepository<Instrument>>();
            services.AddScoped<IGenericRepository<Tempo>, GenericRepository<Tempo>>();
            services.AddScoped<IGenericRepository<Novelty>, GenericRepository<Novelty>>();

        }
    }
}
