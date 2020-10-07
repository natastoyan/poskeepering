using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repository
{
	public class CurrencyRepository: ModelStrIdRepository<Currency>, ICurrencyRepository
	{
		public CurrencyRepository(ModelContext dbContext) : base(dbContext)
		{

		}
	}
}
