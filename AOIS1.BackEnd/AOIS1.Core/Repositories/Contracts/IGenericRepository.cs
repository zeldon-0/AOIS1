using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace AOIS1.Core.Repositories.Contracts
{
    public interface IGenericRepository<Entity>
                where Entity : class
    {
        Task<Entity> FindByIdAsync(int id);
        Task<IEnumerable<Entity>> FindAllAsync();

    }

}
