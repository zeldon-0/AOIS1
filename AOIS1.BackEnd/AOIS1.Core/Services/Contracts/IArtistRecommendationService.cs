using System;
using System.Collections.Generic;
using System.Text;
using AOIS1.API.Contracts.Models.Characteristics;
using AOIS1.API.Contracts.Models.Artists;
using AOIS1.Core.Repositories.Contracts;
using System.Threading.Tasks;

namespace AOIS1.Core.Services.Contracts
{
    public interface IArtistRecommendationService
    {
        Task<ArtistResultModel> GetRecommendedArtistAsync(CharacteristicsQuery query);
    }
}
