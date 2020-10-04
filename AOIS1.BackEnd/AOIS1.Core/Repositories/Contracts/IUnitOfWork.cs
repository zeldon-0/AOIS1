using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Domain.Models.Characteristics;

namespace AOIS1.Core.Repositories.Contracts
{
    public interface IUnitOfWork
    {
        IArtistRepository Artists { get; }
        IGenericRepository<Genre> Genres { get; }
        IGenericRepository<Instrument> Instruments { get; }
        IGenericRepository<Tempo> Tempos { get; }
        IGenericRepository<Novelty> Novelties { get; }
        Task SaveAsync();
    }
}
