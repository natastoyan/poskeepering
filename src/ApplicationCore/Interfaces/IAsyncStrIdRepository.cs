using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
	public interface IAsyncStrIdRepository<T> where T : BaseStrIdModel
	{
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetByIdAsync(string id);
        //Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        //Task<T> AddAsync(T entity);
        //Task UpdateAsync(T entity);
        //Task DeleteAsync(T entity);
        //Task<int> CountAsync(ISpecification<T> spec);
        //Task<T> FirstAsync(ISpecification<T> spec);
        //Task<T> FirstOrDefaultAsync(ISpecification<T> spec);

    }
}

