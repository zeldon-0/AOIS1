using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Domain.Models.Characteristics;
using AOIS1.Core.Repositories.Contracts;
using AOIS1.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AOIS1.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ExpertSystemContext _context;

        public UnitOfWork(ExpertSystemContext context,
            IArtistRepository artistRepository,
            IGenericRepository<Genre> genreRepository,
            IGenericRepository<Instrument> instrumentRepository,
            IGenericRepository<Tempo> tempoRepository,
            IGenericRepository<Novelty> noveltyRepository)
        {

            _context = context ??  throw new ArgumentNullException($"No instance of {nameof(ExpertSystemContext)} provided.");
            Artists = artistRepository ?? throw new ArgumentNullException($"No instance of {nameof(IArtistRepository)} provided.");
            Genres = genreRepository ?? throw new ArgumentNullException($"No instance of {nameof(IGenericRepository<Genre>)} provided.");
            Instruments = instrumentRepository ?? throw new ArgumentNullException($"No instance of {nameof(IGenericRepository<Instrument>)} provided.");
            Tempos = tempoRepository ?? throw new ArgumentNullException($"No instance of {nameof(IGenericRepository<Tempo>)} provided.");
            Novelties = noveltyRepository ?? throw new ArgumentNullException($"No instance of {nameof(IGenericRepository<Novelty>)} provided.");

        }

        public IArtistRepository Artists { get; }

        public IGenericRepository<Genre> Genres { get; }

        public IGenericRepository<Instrument> Instruments { get; }

        public IGenericRepository<Tempo> Tempos { get; }

        public IGenericRepository<Novelty> Novelties { get; }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
