using AOIS1.API.Contracts.Models.Artists;
using AOIS1.API.Contracts.Models.Characteristics;
using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Domain.Models.Characteristics;
using AOIS1.Core.Repositories.Contracts;
using AOIS1.Core.Services.Contracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOIS1.Core.Services
{
    public class RepositoryService : IRepositoryService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public RepositoryService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException($"No instance of {nameof(IUnitOfWork)} provided.");
            _mapper = mapper ?? throw new ArgumentNullException($"No instance of {nameof(IMapper)} provided.");
        }
        public async Task<IEnumerable<ArtistListModel>> GetAllArtistsAsync()
        {
            IEnumerable<Artist> artists = await _unitOfWork.Artists.FindAllAsync();
            IEnumerable<ArtistListModel> artistList = artists
                .Select(a => _mapper.Map<ArtistListModel>(a));

            return artistList;
        }

        public async Task<IEnumerable<InstrumentModel>> GetAllInstrumentsAsync()
        {
            IEnumerable<Instrument> instruments = await _unitOfWork.Instruments.FindAllAsync();
            IEnumerable<InstrumentModel> instrumentList = instruments
                .Select(i => _mapper.Map<InstrumentModel>(i));

            return instrumentList;
        }

        public async Task<IEnumerable<GenreModel>> GetAllGenresAsync()
        {
            IEnumerable<Genre> genres = await _unitOfWork.Genres.FindAllAsync();
            IEnumerable<GenreModel> genreList = genres
                .Select(g => _mapper.Map<GenreModel>(g));

            return genreList;
        }

        public async Task<IEnumerable<NoveltyModel>> GetAllNoveltiesAsync()
        {
            IEnumerable<Novelty> novelties = await _unitOfWork.Novelties.FindAllAsync();
            IEnumerable<NoveltyModel> noveltyList = novelties
                .Select(n => _mapper.Map<NoveltyModel>(n));

            return noveltyList;
        }

        public async Task<IEnumerable<TempoModel>> GetAllTemposAsync()
        {
            IEnumerable<Tempo> tempos = await _unitOfWork.Tempos.FindAllAsync();
            IEnumerable<TempoModel> tempoList = tempos
                .Select(t => _mapper.Map<TempoModel>(t));

            return tempoList;
        }
    }
}
