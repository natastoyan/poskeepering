using Ardalis.Specification;
using ApplicationCore.Models;
using System;

namespace ApplicationCore.Specifications
{
	class VtmCodesSalesPersonSpecification : Specification<VtmCodes>
	{
		public VtmCodesSalesPersonSpecification()
		{
			Query.Where(i => i.Itype == 1);

		}
}
}
