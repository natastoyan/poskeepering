using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

 namespace ApplicationCore.Services
{
	public class OrgsService: IOrgsService
	{
		private readonly IAsyncStrIdRepository<Orgs> _orgsRepository;

		public OrgsService(IAsyncStrIdRepository<Orgs> orgsRepository)
		{
			_orgsRepository = orgsRepository;
		}
		public async Task<List<Orgs>> ListAllAsync()
		{
			var orgsList = await _orgsRepository.ListAllAsync();
			return (List<Orgs>)orgsList;
		}

		public async Task<Orgs> GetByIdAsync(string id)
		{
			var org = await _orgsRepository.GetByIdAsync(id);
			return org;
		}
	}
}
