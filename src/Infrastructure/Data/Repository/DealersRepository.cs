using ApplicationCore.Interfaces;
using ApplicationCore.Models;

namespace Infrastructure.Data.Repository
{
	public class DealersRepository : ModelStrIdRepository<Dealers>, IDealersRepository
	{
		public DealersRepository(ModelContext dbContext) : base(dbContext)
		{

		}
	
	}
}
