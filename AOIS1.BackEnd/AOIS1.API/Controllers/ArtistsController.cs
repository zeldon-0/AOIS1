using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AOIS1.API.Contracts.Models.Artists;
using AOIS1.API.Contracts.Models.Characteristics;
using AOIS1.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AOIS1.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ArtistsController : ControllerBase
    {
        private IArtistRecommendationService _artistRecommendationService;
        private IRepositoryService _repositoryService;

        public ArtistsController(IArtistRecommendationService artistRecommendationService,
            IRepositoryService repositoryService)
        {
            _artistRecommendationService = artistRecommendationService ?? throw new ArgumentNullException($"No instance of {nameof(IArtistRecommendationService)} provided.");
            _repositoryService = repositoryService ?? throw new ArgumentNullException($"No instance of {nameof(IRepositoryService)} provided.");

        }

        [HttpPost]
        public async Task<IActionResult> RecommendArtist(CharacteristicsQuery query)
        {
            ArtistResultModel artist = await _artistRecommendationService.GetRecommendedArtistAsync(query);

            if (artist.Probability == 0)
                return NoContent();

            return Ok(artist);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArtists()
        {
            IEnumerable<ArtistListModel> artists = await _repositoryService.GetAllArtistsAsync();

            return Ok(artists);
        }
    }
}
