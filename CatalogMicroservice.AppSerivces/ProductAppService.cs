using CatalogMicroservice.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.AppSerivces
{
    public class ProductAppService : IProductAppService
    {
        public Task<int> AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task EditProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MakeAppService> GetProductAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
