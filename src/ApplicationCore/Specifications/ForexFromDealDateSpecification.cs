using Ardalis.Specification;
using ApplicationCore.Models;
using System;


namespace ApplicationCore.Specifications
{
	public class ForexFromDealDateSpecification : Specification<Forex>
	{
		public ForexFromDealDateSpecification(DateTime date)
		{
			Query.Where(i => i.Dcontrdate > date);
		}
	}
}
