using CatalogMicroservice.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.AppSerivces
{
    public interface IProductAppService
    {

        //Get all
        Task<List<Product>> GetProductAllAsync();
        //Create
        Task<int> AddProductAsync(Product product);
        //Delete
        Task DeleteProductAsync(int productId);
        //Get ID
        Task<MakeAppService> GetProductAsync(int productId);
        //Update
        Task EditProductAsync(Product product);

    }
}
