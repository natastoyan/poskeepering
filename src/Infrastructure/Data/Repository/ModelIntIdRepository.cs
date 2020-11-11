using ApplicationCore.Interfaces;
using ApplicationCore.Models;

namespace Infrastructure.Data.Repository
{
    public class ModelIntIdRepository<T> : ModelAsyncRepository<T, decimal>, IAsyncIntIdRepository<T> where T : BaseIntIdModel
	{
        public ModelIntIdRepository(ModelContext dbContext): base(dbContext)
		{
	
		}
    }
}
