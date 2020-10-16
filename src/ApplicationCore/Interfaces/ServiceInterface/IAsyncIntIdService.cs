using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
	public interface IAsyncIntIdService<T> where T: BaseIntIdModel
	{
		public Task<List<T>> ListAllAsync();
		public Task<T> GetByIdAsync(decimal id);
	}
}
