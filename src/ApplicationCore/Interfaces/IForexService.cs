using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
	public interface IForexService
	{
		Task AddNewForex(Forex newForex);
		Task<List<Forex>> ListAsync(ISpecification<Forex> spec);
		Task<List<Forex>> ListLastYearAsync();
	}
}
