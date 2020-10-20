using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using System.Threading.Tasks;
using System.Collections.Generic;
using ApplicationCore.Models;
using Ardalis.Specification;
using System;

namespace ApplicationCore.Services
{
	public class DepoService: IDepoService
	{
		private readonly IAsyncIntIdRepository<Depo> _depoRepository;

		public DepoService(IAsyncIntIdRepository<Depo> depoRepository)
		{
			_depoRepository = depoRepository;
		}
		public async Task AddNewDepo(Depo newDepo)
		{
			await _depoRepository.AddAsync(newDepo);
		}

		public async Task<List<Depo>> ListAsync(ISpecification<Depo> spec)
		{
			var depoList = (List<Depo>) await _depoRepository.ListAsync(spec);
			return depoList;
		}
		public async Task<List<Depo>> ListAsyncFromDate(DateTime dateFrom)
		{
			DepoFromDealDateSpecification spec = new DepoFromDealDateSpecification(dateFrom);
			var depoList = await _depoRepository.ListAsync(spec);
			return (List<Depo>)depoList;
		}
		public async Task<List<Depo>> ListLastYearAsync()
		{

			DepoFromDealDateSpecification spec = new DepoFromDealDateSpecification(new DateTime(2019, 1, 1));
			var depoList =  await _depoRepository.ListAsync(spec);
			return (List<Depo>)depoList;
		}
	}
}
