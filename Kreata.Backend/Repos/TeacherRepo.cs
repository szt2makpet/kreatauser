using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public TeacherRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Teacher?> GetBy(Guid id)
        {
            return await _dbContext.Teachers.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Teacher>> GetAll()
        {
            int count = _dbContext.Teachers.Count();
            return await _dbContext.Teachers.ToListAsync();
        }
    }
}
