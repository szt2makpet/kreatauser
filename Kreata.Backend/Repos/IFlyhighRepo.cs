using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IFlyhighRepo
    {
        Task<List<Flyhigh>> GetAll();
        Task<Flyhigh?> GetBy(Guid id);
    }
}
