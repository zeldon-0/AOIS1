using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AOIS1.Core.Domain.Models.Artists;

namespace AOIS1.Core.Repositories.Contracts
{
    public interface IArtistRepository : IGenericRepository<Artist>
    {
        Task<Artist> GetAllArtistWithRelatedEntitiesAsync();
    }
}
