using CHURCH.Domain.Entities;

namespace CHURCH.Application.Interface
{
    public interface IDistritoRepository
    {
        Task<IEnumerable<Distritos>> ListDistritos();
    }
}
