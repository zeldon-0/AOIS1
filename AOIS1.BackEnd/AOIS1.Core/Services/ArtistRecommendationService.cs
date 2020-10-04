using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOIS1.API.Contracts.Models.Artists;
using AOIS1.API.Contracts.Models.Characteristics;
using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Domain.Models.JoinEntities;
using AOIS1.Core.Repositories.Contracts;
using AOIS1.Core.Services.Contracts;
using AutoMapper;

namespace AOIS1.Core.Services
{
    public class ArtistRecommendationService : IArtistRecommendationService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public ArtistRecommendationService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException($"No instance of {nameof(IUnitOfWork)} provided.");
            _mapper = mapper ?? throw new ArgumentNullException($"No instance of {nameof(IMapper)} provided.");
        }
        public async Task<ArtistResultModel> GetRecommendedArtistAsync(CharacteristicsQuery query)
        {
            IEnumerable<Artist> artists = await _unitOfWork.Artists.GetAllArtistWithRelatedEntitiesAsync();
            IEnumerable<ArtistWithProbability> artistsWithProbabilities =
                artists.Select(a => _mapper.Map<ArtistWithProbability>(a));

            foreach(ArtistWithProbability artist in artistsWithProbabilities)
            {
                CalculateProbability(artist, query);
            }

            decimal highestProbability = artistsWithProbabilities.Select(
                a => a.GetProbabilityValue()).Max();

            var mostLikelyArtist = artistsWithProbabilities.FirstOrDefault(
                a => a.GetProbabilityValue() == highestProbability);

            return _mapper.Map<ArtistResultModel>(mostLikelyArtist);

        }

        private void CalculateProbability(ArtistWithProbability artist, CharacteristicsQuery query)
        {
            foreach(GenreModel genre in query.Genres)
            {
                ArtistGenre artistGenre = artist.ArtistGenres.FirstOrDefault(ag => ag.GenreId == genre.Id);

                if(artistGenre == null)
                {
                    artist.CalculateProbability(0);
                    return;
                }

                artist.CalculateProbability(artistGenre.Probability);
            }

            foreach (InstrumentModel instrument in query.Instruments)
            {
                ArtistInstrument artistInstrument = artist.ArtistInstruments.FirstOrDefault(ai => ai.InstrumentId == instrument.Id);

                if (artistInstrument == null)
                {
                    artist.CalculateProbability(0);
                    return;
                }

                artist.CalculateProbability(artistInstrument.Probability);
            }

            foreach (TempoModel tempo in query.Tempos)
            {
                ArtistTempo artistTempo = artist.ArtistTempos.FirstOrDefault(at => at.TempoId == tempo.Id);

                if (artistTempo == null)
                {
                    artist.CalculateProbability(0);
                    return;
                }

                artist.CalculateProbability(artistTempo.Probability);
            }
            foreach (NoveltyModel novelty in query.Novelties)
            {
                ArtistNovelty artistNovelty = artist.ArtistNovelties.FirstOrDefault(an => an.NoveltyId == novelty.Id);

                if (artistNovelty == null)
                {
                    artist.CalculateProbability(0);
                    return;
                }

                artist.CalculateProbability(artistNovelty.Probability);
            }
        }
    }
}
