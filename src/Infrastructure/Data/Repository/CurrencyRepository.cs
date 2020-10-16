using ApplicationCore.Interfaces;
using ApplicationCore.Models;


namespace Infrastructure.Data.Repository
{
	public class CurrencyRepository: ModelStrIdRepository<Currency>, ICurrencyRepository
	{
		public CurrencyRepository(ModelContext dbContext) : base(dbContext)
		{

		}
	}
}
