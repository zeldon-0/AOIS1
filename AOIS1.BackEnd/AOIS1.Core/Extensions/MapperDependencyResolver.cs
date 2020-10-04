using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AutoMapper;
using AOIS1.Core.Mapping;

namespace AOIS1.Core.Extensions
{
    public static class MapperDependencyResolver
    {
        public static void AddMapper( this IServiceCollection services)
        {
            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
                    mc.AddProfile(new MappingProfile())
            );
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
