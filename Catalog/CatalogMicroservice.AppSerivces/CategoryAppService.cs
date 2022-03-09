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
       
        private readonly IRepository<int, Category> _repository;
        public CategoryAppService(IRepository<int, Category> repository)
        {
            _repository = repository;
        }


        //Insert
        public async Task<int> AddCategoryAsync(Category category)
        {
            await _repository.AddAsync(category);

            return category.IdCategory;
        }

        //Delete
        public async Task DeleteCategoryAsync(int categoryId)
        {
            await _repository.DeleteAsync(categoryId);
        }

        //Update

        public async Task EditCategoryAsync(Category category)
        {
            await _repository.UpdateAsync(category);

        }

        //Get ALL
        public async Task<IList<Category>> GetCategoryAllAsync()
        {

            return await _repository.GetAll();
        }
        //Get Id
        public async Task<Category> GetCategoryAsync(int categoryId)
        {
            return await _repository.GetAsync(categoryId);

            
        }


    }
}
