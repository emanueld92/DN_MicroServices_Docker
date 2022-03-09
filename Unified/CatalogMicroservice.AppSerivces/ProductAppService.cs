using CatalogMicroservice.Core.Entity;
using CatalogMicroservice.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.AppSerivces
{
    public class ProductAppService : IProductAppService
    {
        private readonly IRepository<int, Product> _repository;
        public ProductAppService(IRepository<int, Product> repository)
        {
            _repository = repository;
        }

        //Insert
        public async Task<int> AddProductAsync(Product product)
        {


            await _repository.AddAsync(product);

            return product.IdProduct;
        }

        //Delte
        public async Task DeleteProductAsync(int productId)
        {
            await _repository.DeleteAsync(productId);
        }

        //Update

        public async Task EditProductAsync(Product product)
        {
            await _repository.UpdateAsync(product);

        }

        //Get all
        public async Task<IList<Product>> GetProductAllAsync()
        {
            return await _repository.GetAll();
        }
        //Get Id
        public async Task<Product> GetProductAsync(int productId)
        {
            return await _repository.GetAsync(productId);
        }


    }
}
