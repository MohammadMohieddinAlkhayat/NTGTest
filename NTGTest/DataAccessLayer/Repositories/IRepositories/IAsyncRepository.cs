using NTGTest.DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace NTGTest.DataAccessLayer.Repositories.IRepositories
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {        
        Task<T> AddAsync(T entity);
    }
}
