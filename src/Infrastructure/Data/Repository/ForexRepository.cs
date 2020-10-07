using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using ApplicationCore.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;

namespace Infrastructure.Data.Repository
{
	//public class ForexRepository : EfRepository<Forex>, IForexRepository
	//{
	//	public ForexRepository(ModelContext dbContext) : base(dbContext)
	//	{ }


	//}
	public class ForexRepository : ModelIntIdRepository<Forex>, IForexRepository
	{
		public ForexRepository(ModelContext dbContext) : base(dbContext)
		{

		}
	}


	//IEnumerable<Forex> IForexRepository.ListAll()
	//	{
	//		return _dbContext.Forex;
	//	}
	//}

}