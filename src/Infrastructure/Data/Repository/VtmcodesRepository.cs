using ApplicationCore.Models;
using ApplicationCore.Interfaces;

namespace Infrastructure.Data.Repository
{
	public class VtmcodesRepository : ModelIntIdRepository<VtmCodes>, IVtmcodesRepository
	{
		public VtmcodesRepository(ModelContext dbContext) : base(dbContext)
		{

		}
	}

}