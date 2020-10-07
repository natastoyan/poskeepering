using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
	public class CurrencyService : ICurrencyService
	{
		private readonly IAsyncStrIdRepository<Currency> _currencyRepository;

		public CurrencyService(IAsyncStrIdRepository<Currency> currencyRepository)
		{
			_currencyRepository = currencyRepository;
		}
		public async Task<List<Currency>> ListAllAsync()
		{
			var currencyList = await _currencyRepository.ListAllAsync();
			return (List<Currency>)currencyList;
		}

		public async Task<Currency> GetByIdAsync(string id)
		{
			var currency = await _currencyRepository.GetByIdAsync(id);
			return currency;
		}
	}
}
