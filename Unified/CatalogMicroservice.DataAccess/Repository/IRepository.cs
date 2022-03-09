using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.DataAccess
{
    public interface IRepository<TId, TEntity> where TEntity : class, new()
    {
        //GET ALL
        Task<IList<TEntity>> GetAll();
        //GET ID
        Task<TEntity> GetAsync(TId id);
        //INSERT
        Task<TEntity> AddAsync(TEntity entity);
        //UPDATE
        Task<TEntity> UpdateAsync(TEntity entity);
        //DELETE
        Task DeleteAsync(TId id);
    }
}
