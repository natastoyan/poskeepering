using ApplicationCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
	public interface IAsyncIntIdService<T> where T: BaseIntIdModel
	{
		public Task<List<T>> ListAllAsync();
		public Task<T> GetByIdAsync(decimal id);
		Task<List<T>> ListAsync(ISpecification<T> spec);
	}
}
