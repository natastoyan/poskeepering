using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
	public interface IAsyncStrIdService<T> where T: BaseStrIdModel
	{
		public Task<List<T>> ListAllAsync();
		public Task<T> GetByIdAsync(string id);
	}
}
