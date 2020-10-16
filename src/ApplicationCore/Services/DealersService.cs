using ApplicationCore.Interfaces;
using ApplicationCore.Models;

namespace ApplicationCore.Services
{
	public class DealersService: ModelStrIdService<Dealers>, IDealersService
	{
		public DealersService(IAsyncStrIdRepository<Dealers> repository) : base(repository)
		{

		}
	
	}
}
