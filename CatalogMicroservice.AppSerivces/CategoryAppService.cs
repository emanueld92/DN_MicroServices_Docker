using CatalogMicroservice.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogMicroservice.AppSerivces
{
    public class CategoryAppService : ICategoryAppService
    {
        public Task<int> AddCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task EditCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetCategoryAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MakeAppService> GetCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
