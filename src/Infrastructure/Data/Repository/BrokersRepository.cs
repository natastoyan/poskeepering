using ApplicationCore.Interfaces;
using ApplicationCore.Models;


namespace Infrastructure.Data.Repository
{
	public class BrokersRepository : ModelIntIdRepository<Brokers>, IBrokersRepository
	{
		public BrokersRepository(ModelContext dbContext) : base(dbContext)
		{

		}
	
	}
}
