using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AOIS1.Core.Repositories.Contracts;
using AOIS1.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AOIS1.Data.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity>
        where Entity : class
    {
        private ExpertSystemContext _context;
        
        public GenericRepository(ExpertSystemContext context)
        {
            _context = context ?? throw new ArgumentNullException($"No instance of {nameof(ExpertSystemContext)} provided.");
        }
        public async Task<IEnumerable<Entity>> FindAllAsync()
        {
            return await _context.Set<Entity>().ToListAsync();
        }

        public async Task<Entity> FindByIdAsync(int id)
        {
            return await _context.Set<Entity>().FindAsync(id);

        }
    }
}
