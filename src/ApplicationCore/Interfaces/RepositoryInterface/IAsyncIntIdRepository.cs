using ApplicationCore.Models;

namespace ApplicationCore.Interfaces

{
	public interface IAsyncIntIdRepository<T>: IAsyncIdRepository<T, decimal> where T : BaseIntIdModel
	{
        
    }
}
