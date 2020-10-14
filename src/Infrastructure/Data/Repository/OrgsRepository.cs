using ApplicationCore.Interfaces;
using ApplicationCore.Models;

namespace Infrastructure.Data.Repository
{
	public class OrgsRepository : ModelStrIdRepository<Orgs>, IOrgsRepository
	{
		public OrgsRepository(ModelContext dbContext) : base(dbContext)
	{

	}
}
}
