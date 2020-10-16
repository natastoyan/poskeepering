using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.Interfaces
{
	public interface IOrgsService
	{
		public Task<List<Orgs>> ListAllAsync();
		public Task<Orgs> GetByIdAsync(string id);
	}
}
