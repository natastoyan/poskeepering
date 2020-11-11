using System;
using ApplicationCore.Interfaces;

namespace Infrastructure.Data.Repository
{
    public class ModelGenericRepository<T> : ModelAsyncRepository<T, object> where T: class
    {
        public ModelGenericRepository(ModelContext dbContext): base(dbContext)
        {
            
        }
    }
}