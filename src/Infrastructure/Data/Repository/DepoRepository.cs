using ApplicationCore.Interfaces;
using ApplicationCore.Models;


namespace Infrastructure.Data.Repository
{
	public class DepoRepository : ModelIntIdRepository<Depo> , IDepoRepository
	{
		public DepoRepository(ModelContext dbContext) : base(dbContext)
		{

		}
	}
}
