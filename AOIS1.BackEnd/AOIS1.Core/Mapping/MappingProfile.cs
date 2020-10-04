using System;
using System.Collections.Generic;
using System.Text;
using AOIS1.API.Contracts.Models.Artists;
using AOIS1.API.Contracts.Models.Characteristics;
using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Domain.Models.Characteristics;
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

            CreateMap<Genre, GenreModel>()
                .ReverseMap();

            CreateMap<Instrument, InstrumentModel>()
                .ReverseMap();
            
            CreateMap<Tempo, TempoModel>()
                .ReverseMap();

            CreateMap<Novelty, NoveltyModel>()
                .ReverseMap();

        }
    }
}
