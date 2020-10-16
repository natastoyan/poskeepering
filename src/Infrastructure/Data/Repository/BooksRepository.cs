using ApplicationCore.Interfaces;
using ApplicationCore.Models;

namespace Infrastructure.Data.Repository
{
	public class BooksRepository : ModelStrIdRepository<Books>, IBooksRepository
	{
		public BooksRepository(ModelContext dbContext) : base(dbContext)
		{

		}
	}
}
