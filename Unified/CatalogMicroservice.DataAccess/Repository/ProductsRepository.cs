using CatalogMicroservice.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.DataAccess.Repository
{
    public class ProductsRepository:Repository<int,Product>
    {
        public ProductsRepository(CatalogMicroserviceContext context):base(context)
        {

        }


        public override async Task<Product> AddAsync(Product entity)
        {
            var make = await Context.Makes.FindAsync(entity.Make.IdMake);
            var category = await Context.Categories.FindAsync(entity.Category.IdCategory);

        // entity.Category = null;
          ///  entity.Make = null;

            await Context.Products.AddAsync(entity);
            make.Products.Add(entity);
            category.Products.Add(entity);

            await Context.SaveChangesAsync();

            return entity;
        }


        public override async Task<Product> GetAsync(int id)
        {

            var product = await Context.Products.Include(x => x.Make).Include(x => x.Category).FirstOrDefaultAsync(x => x.IdProduct == id);


            return product;
        }

        public override async Task<Product> UpdateAsync(Product entity)
        {
            var make = await Context.Makes.FindAsync(entity.Make.IdMake);
            var categories = await Context.Categories.FindAsync(entity.Category.IdCategory);
            entity.Make = null;
            entity.Category = null;
            make.Products.Add(entity);
            categories.Products.Add(entity);

            var product = await Context.Products.FindAsync(entity.IdProduct);

            product.NameProduct = entity.NameProduct;
       



            await Context.SaveChangesAsync();

            return product;
        }
    }
}
