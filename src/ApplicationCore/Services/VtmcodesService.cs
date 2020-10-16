using ApplicationCore.Models;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationCore.Services
{
	public class VtmcodesService : ModelIntIdService<VtmCodes>, IVtmcodesService
	{
		public VtmcodesService(IAsyncIntIdRepository<VtmCodes> repository) : base(repository)
		{

		}

		async Task<List<VtmCodes>> IVtmcodesService.ListSalesPersonAsync()
		{

			VtmCodesSalesPersonSpecification spec = new VtmCodesSalesPersonSpecification();
			var list = await _repository.ListAsync(spec);
			var orderedList  = list.OrderBy(item => item.Cname);
			return (List<VtmCodes>)list;
		}
	}
}
