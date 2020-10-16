using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using ApplicationCore.Models;

using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
	public interface IDepoService
	{
		Task AddNewDepo(Depo newDepo);
		Task<List<Depo>> ListAsync(ISpecification<Depo> spec);
		Task<List<Depo>> ListLastYearAsync();      
	}
}
