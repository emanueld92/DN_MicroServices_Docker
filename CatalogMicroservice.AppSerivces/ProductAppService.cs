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
        private readonly CatalogMicroserviceContext _dataContext;
        public ProductAppService(CatalogMicroserviceContext dataContext) => _dataContext = dataContext;


        //Insert
        public async Task AddProductAsync(Product product)
        {
            

            await _dataContext.Products.AddAsync(product);
            await _dataContext.SaveChangesAsync();
        }

        //Delte
        public async Task DeleteProductAsync(int productId)
        {
            var entity = await _dataContext.Products.FindAsync(productId);
            _dataContext.Products.Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        //Update

        public async Task EditProductAsync(Product product)
        {
            var entity = await _dataContext.Products.FindAsync(product.IdProduct);
            entity.NameProduct= product.NameProduct;
            entity.Make = product.Make;
            entity.Category = product.Category;
            await _dataContext.SaveChangesAsync();

        }

        //Get all
        public async Task<IList<Product>> GetProductAllAsync()
        {
            var result = await _dataContext.Products.ToListAsync();
            return result;
        }
        //Get Id
        public async Task<Product> GetProductAsync(int productId)
        {
            var entity = await _dataContext.Products.FindAsync(productId);

            return entity;
        }


    }
}
