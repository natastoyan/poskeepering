using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using ApplicationCore.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repository
{
	public class ModelStrIdRepository<T> : IAsyncStrIdRepository<T> where T : BaseStrIdModel
	{
		protected readonly ModelContext _dbContext;

		public ModelStrIdRepository(ModelContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<IReadOnlyList<T>> ListAllAsync()
		{
			return await _dbContext.Set<T>().ToListAsync();
		}
		public virtual async Task<T> GetByIdAsync(string id)
		{
			return await _dbContext.Set<T>().FindAsync(id);
		}

	}
}
