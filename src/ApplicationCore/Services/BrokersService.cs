using ApplicationCore.Models;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
	public class BrokersService: ModelIntIdService<Brokers>, IBrokersService
	{
		public BrokersService(IAsyncIntIdRepository<Brokers> repository) : base(repository)
		{

		}
	
	}
}
