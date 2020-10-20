using System.Threading.Tasks;
using System.Collections.Generic;
using System;
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

		Task<List<Depo>> ListAsyncFromDate(DateTime dateFrom);
		Task<List<Depo>> ListLastYearAsync();      
	}
}
