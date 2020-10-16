using Ardalis.Specification;
using ApplicationCore.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Interfaces;


namespace ApplicationCore.Services
{
	public class ModelStrIdService<T> : IAsyncStrIdService<T> where T : BaseStrIdModel
	{
		protected readonly IAsyncStrIdRepository<T> _repository;

		public ModelStrIdService(IAsyncStrIdRepository<T> repository)
		{
			_repository = repository;
		}
		async Task<T> IAsyncStrIdService<T>.GetByIdAsync(string id)
		{
			var item = await _repository.GetByIdAsync(id);
			return item;
		}

		async Task<List<T>> IAsyncStrIdService<T>.ListAllAsync()
		{
			var list = await _repository.ListAllAsync();
			return (List<T>)list;
		}
	}
}
