using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces

{
	public interface IAsyncIntIdRepository<T> where T : BaseIntIdModel
	{
        Task<T> GetByIdAsync(decimal id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(ISpecification<T> spec);
        Task<T> FirstAsync(ISpecification<T> spec);
        Task<T> FirstOrDefaultAsync(ISpecification<T> spec);

    }

}
