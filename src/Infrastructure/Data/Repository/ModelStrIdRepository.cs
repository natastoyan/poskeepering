using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using ApplicationCore.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repository
{
	public class ModelStrIdRepository<T> : ModelAsyncRepository<T, string>, IAsyncStrIdRepository<T> where T : BaseStrIdModel
	{
		
		public ModelStrIdRepository(ModelContext dbContext): base(dbContext)
		{
		
		}
    }
}
