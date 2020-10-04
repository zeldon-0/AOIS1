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
    [Route("api/")]
    public class RepositoryController : ControllerBase
    {
        private IRepositoryService _repositoryService;

        public RepositoryController(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService ?? throw new ArgumentNullException($"No instance of {nameof(IRepositoryService)} provided.");

        }

        [HttpGet("genres/[action]")]
        public async Task<IActionResult> GetAllGenres()
        {
            IEnumerable<GenreModel> genres = await _repositoryService.GetAllGenresAsync();

            return Ok(genres);
        }

        [HttpGet("instruments/[action]")]
        public async Task<IActionResult> GetAllInstruments()
        {
            IEnumerable<InstrumentModel> instruments = await _repositoryService.GetAllInstrumentsAsync();

            return Ok(instruments);
        }

        [HttpGet("tempo/[action]")]
        public async Task<IActionResult> GetAllTempos()
        {
            IEnumerable<TempoModel> tempos = await _repositoryService.GetAllTemposAsync();

            return Ok(tempos);
        }

        [HttpGet("novelty/[action]")]
        public async Task<IActionResult> GetAllNovelties()
        {
            IEnumerable<NoveltyModel> novelties = await _repositoryService.GetAllNoveltiesAsync();

            return Ok(novelties);
        }
    }
}
