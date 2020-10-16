using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
	public class ModelIntIdService<T> : IAsyncIntIdService<T> where T : BaseIntIdModel
	{
		protected readonly IAsyncIntIdRepository<T> _repository;

		public ModelIntIdService(IAsyncIntIdRepository<T> repository)
		{
			_repository = repository;
		}
		async Task<T> IAsyncIntIdService<T>.GetByIdAsync(decimal id)
		{
			var item = await _repository.GetByIdAsync(id);
			return item;
		}

		async Task<List<T>> IAsyncIntIdService<T>.ListAllAsync()
		{
			var list = await _repository.ListAllAsync();
			return (List<T>)list;
		}

		Task<List<T>> IAsyncIntIdService<T>.ListAsync(ISpecification<T> spec)
		{
			throw new NotImplementedException();
		}
	}
}
