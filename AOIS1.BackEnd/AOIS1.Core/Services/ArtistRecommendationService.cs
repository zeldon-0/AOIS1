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
using AutoMapper.Internal;
using Microsoft.Extensions.Logging;

namespace AOIS1.Core.Services
{
    public class ArtistRecommendationService : IArtistRecommendationService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private ILogger _logger;
        public ArtistRecommendationService(IUnitOfWork unitOfWork,
            IMapper mapper, ILogger<ArtistResultModel> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException($"No instance of {nameof(IUnitOfWork)} provided.");
            _mapper = mapper ?? throw new ArgumentNullException($"No instance of {nameof(IMapper)} provided.");
            _logger = logger ?? throw new ArgumentNullException($"No instance of {nameof(ILogger)} provided.");
        }
        public async Task<ArtistResultModel> GetRecommendedArtistAsync(CharacteristicsQuery query)
        {
            IEnumerable<Artist> artists = await _unitOfWork.Artists.GetAllArtistWithRelatedEntitiesAsync();
            IEnumerable<ArtistWithProbability> artistsWithProbabilities =
                artists.Select(a => _mapper.Map<ArtistWithProbability>(a)).ToArray();

            foreach(ArtistWithProbability artist in artistsWithProbabilities)
            {
                CalculateProbability(artist, query);
                _logger.LogInformation($"Current Value of probability for {artist.Name} is: {artist.GetProbabilityValue()}");
            }

            decimal highestProbability = artistsWithProbabilities.Select(
                a => a.GetProbabilityValue()).Max();

            _logger.LogInformation($"Current Highest Probability is : {highestProbability}");

            var mostLikelyArtist = artistsWithProbabilities.FirstOrDefault(
                a => a.GetProbabilityValue() == highestProbability);

            _logger.LogInformation($"Most Likely Artist : {mostLikelyArtist.Name}");
            return _mapper.Map<ArtistResultModel>(mostLikelyArtist);

        }

        private void CalculateProbability(ArtistWithProbability artist, CharacteristicsQuery query)
        {
            if (query.Genres != null)
            {
                foreach (GenreModel genre in query.Genres)
                {
                    ArtistGenre artistGenre = artist.ArtistGenres.FirstOrDefault(ag => ag.GenreId == genre.Id);

                    if (artistGenre == null)
                    {
                        artist.CalculateProbability(0);
                        return;
                    }

                    artist.CalculateProbability(artistGenre.Probability);
                }
            }
            if (query.Instruments != null)
            {
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
            }

            if (query.Tempos != null)
            {
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
            }

            if (query.Novelties != null)
            {
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
}
