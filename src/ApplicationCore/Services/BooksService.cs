using ApplicationCore.Interfaces;

using ApplicationCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
	public class BooksService : ModelStrIdService<Books>, IBooksService
	{
		public BooksService(IAsyncStrIdRepository<Books> repository): base(repository)
		{
	
		}
	}
}
