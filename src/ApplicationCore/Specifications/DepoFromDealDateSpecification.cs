using Ardalis.Specification;
using ApplicationCore.Models;
using System;

namespace ApplicationCore.Specifications
{
	public class DepoFromDealDateSpecification : Specification<Depo>
	{
		public DepoFromDealDateSpecification(DateTime date)
		{
			Query.Where(i => i.Dcontrdate > date);

		}
	}
}
