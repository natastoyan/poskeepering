using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IAsyncIdRepository<T, TKey>: IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(TKey id);

    }
}