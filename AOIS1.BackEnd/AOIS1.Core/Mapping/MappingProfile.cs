using System;
using System.Collections.Generic;
using System.Text;
using AOIS1.API.Contracts.Models.Artists;
using AOIS1.Core.Domain.Models.Artists;
using AutoMapper;

namespace AOIS1.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Artist, ArtistWithProbability>()
                .ReverseMap();

            CreateMap<ArtistWithProbability, ArtistResultModel>()
                .ForMember(dest => dest.Probability,
                opt => opt.MapFrom(
                src => src.GetProbabilityValue()))
                .ReverseMap();
        }
    }
}
