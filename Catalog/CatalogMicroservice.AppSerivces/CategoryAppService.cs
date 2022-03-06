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
    public class CategoryAppService : ICategoryAppService
    {
        private readonly CatalogMicroserviceContext _dataContext;
        public CategoryAppService(CatalogMicroserviceContext dataContext) => _dataContext = dataContext;


        //Insert
        public async Task AddCategoryAsync(Category category)
        {
            await _dataContext.Categories.AddAsync(category);
            await _dataContext.SaveChangesAsync();
        }

        //Delte
        public async Task DeleteCategoryAsync(int categoryId)
        {
            var entity = await _dataContext.Categories.FindAsync(categoryId);
            _dataContext.Categories.Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        //Update

        public async Task EditCategoryAsync(Category category)
        {
            var entity = await _dataContext.Categories.FindAsync(category.IdCategory);
            entity.NameCategory = category.NameCategory;
            await _dataContext.SaveChangesAsync();

        }

        //Get all
        public async Task<IList<Category>> GetCategoryAllAsync()
        {
            var result = await _dataContext.Categories.ToListAsync();
            return result;
        }
        //Get Id
        public async Task<Category> GetCategoryAsync(int categoryId)
        {
            var entity = await _dataContext.Categories.FindAsync(categoryId);

            return entity;
        }




    }
}
