using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Repositories.Contracts;
using AOIS1.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace AOIS1.Data.Repositories
{
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        private ExpertSystemContext _context;

        public ArtistRepository(ExpertSystemContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException($"No instance of {nameof(ExpertSystemContext)} provided.");
        }
        public async Task<IEnumerable<Artist>> GetAllArtistWithRelatedEntitiesAsync()
        {
            IEnumerable<Artist> artists = await _context.Artists
                .Include(a => a.ArtistGenres)
                .Include(a => a.ArtistInstruments)
                .Include(a => a.ArtistNovelties)
                .Include(a => a.ArtistTempos)
                .ToListAsync();

            return artists;
        }
    }
}
