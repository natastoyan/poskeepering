using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
	public interface ICurrencyService
	{
		public Task<List<Currency>> ListAllAsync();
		public Task<Currency> GetByIdAsync(string id);
	}
}
