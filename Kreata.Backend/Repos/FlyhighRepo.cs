using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class FlyhighRepo : IFlyhighRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public FlyhighRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Flyhigh?> GetBy(Guid id)
        {
            return await _dbContext.Flyhighs.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Flyhigh>> GetAll()
        {
            int count = _dbContext.Flyhighs.Count();
            return await _dbContext.Flyhighs.ToListAsync();
        }
    }
}
