using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;
using Ardalis.Specification;

namespace ApplicationCore.Interfaces
{
	public interface IAsyncStrIdRepository<T>: IAsyncIdRepository<T, string> where T : BaseStrIdModel
	{

    }
}

