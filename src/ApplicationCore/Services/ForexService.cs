using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using System.Threading.Tasks;
using System.Collections.Generic;
using ApplicationCore.Models;
using Ardalis.Specification;
using System;

namespace ApplicationCore.Services
{
	public class ForexService : IForexService
	{
		private readonly IAsyncIntIdRepository<Forex> _forexRepository;

		public ForexService(IAsyncIntIdRepository<Forex> forexRepository)
		{
			_forexRepository = forexRepository;
		}
		public async Task AddNewForex(Forex newForex)
		{
			await _forexRepository.AddAsync(newForex);
		}

		public async Task<List<Forex>> ListAsync(ISpecification<Forex> spec)
		{
			List<Forex> forexList = (List<Forex>) await _forexRepository.ListAsync(spec);
			return forexList;
		}

		public async  Task<List<Forex>> ListLastYearAsync()
		{
			ForexFromDealDateSpecification spec = new ForexFromDealDateSpecification(new DateTime(2019, 1, 1));
			var forexList =  await _forexRepository.ListAsync(spec);
			return (List<Forex>)forexList;
		}
	}
}
