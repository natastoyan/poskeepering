using ApplicationCore.Models;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ApplicationCore.Interfaces
{
	public interface IVtmcodesService: IAsyncIntIdService<VtmCodes>
	{
		Task<List<VtmCodes>> ListSalesPersonAsync();
	}
}
